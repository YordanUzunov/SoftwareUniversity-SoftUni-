namespace SoftJail.DataProcessor
{
    using Newtonsoft.Json;
    using SoftJail.Data.Models;
    using SoftJail.DataProcessor.ImportDto;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Text;

    using Data;
    using System.Globalization;
    using System.Xml.Serialization;
    using System.IO;
    using SoftJail.Data.Models.Enums;
    using System.Linq;
    using AutoMapper;

    public class Deserializer
    {
        public const string ErrorMessage = "Invalid Data";
        private const string RootElementName = "Officers";

        public static string ImportDepartmentsCells(SoftJailDbContext context, string jsonString)
        {
            var sb = new StringBuilder();

            var deserializedJson = JsonConvert.DeserializeObject<DepartmentCellsDto[]>(jsonString);

            var departments = new List<Department>();

            foreach (var departmentCellsDto in deserializedJson)
            {
                if (!IsValid(departmentCellsDto))
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                var cellsByDept = new List<Cell>();
                bool allCellsAreValid = true;

                foreach (var cellDto in departmentCellsDto.Cells)
                {
                    if (!IsValid(cellDto))
                    {
                        sb.AppendLine(ErrorMessage);
                        allCellsAreValid = false;
                        break;
                    }

                    var cell = new Cell
                    {
                        CellNumber = cellDto.CellNumber,
                        HasWindow = cellDto.HasWindow
                    };

                    cellsByDept.Add(cell);
                }

                if (allCellsAreValid == true)
                {
                    var deptName = departmentCellsDto.Name;

                    var dept = new Department
                    {
                        Name = deptName,
                        Cells = cellsByDept
                    };

                    departments.Add(dept);
                    sb.AppendLine($"Imported {deptName} with {cellsByDept.Count} cells");
                }
            }

            context.Departments.AddRange(departments);
            context.SaveChanges();

            var result = sb.ToString();
            return result;
        }

        public static string ImportPrisonersMails(SoftJailDbContext context, string jsonString)
        {
            var sb = new StringBuilder();

            var deserializedJson = JsonConvert.DeserializeObject<PrisonerDto[]>(jsonString);

            var prisoners = new List<Prisoner>();

            foreach (var prisonerDto in deserializedJson)
            {
                if (!IsValid(prisonerDto))
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                var mailsByPrisoner = new List<Mail>();
                bool allMailsAreValid = true;

                foreach (var mailDto in prisonerDto.Mails)
                {
                    if (!IsValid(mailDto))
                    {
                        sb.AppendLine(ErrorMessage);
                        allMailsAreValid = false;
                        break;
                    }

                    var mail = new Mail
                    {
                        Description = mailDto.Description,
                        Sender = mailDto.Sender,
                        Address = mailDto.Address
                    };

                    mailsByPrisoner.Add(mail);
                }

                if (allMailsAreValid == true)
                {
                    var prisoner = new Prisoner
                    {
                        FullName = prisonerDto.FullName,
                        Nickname = prisonerDto.Nickname,
                        Age = prisonerDto.Age,
                        IncarcerationDate = DateTime.ParseExact(prisonerDto.IncarcerationDate, "dd/MM/yyyy", CultureInfo.InvariantCulture),
                        ReleaseDate = String.IsNullOrEmpty(prisonerDto.ReleaseDate) ? 
                                            (DateTime?)null 
                                            : DateTime.ParseExact(prisonerDto.ReleaseDate, "dd/MM/yyyy", CultureInfo.InvariantCulture),
                        Bail = prisonerDto.Bail,
                        CellId = prisonerDto.CellId,
                        Mails = mailsByPrisoner
                    };

                    prisoners.Add(prisoner);
                    sb.AppendLine($"Imported {prisonerDto.FullName} {prisonerDto.Age} years old");
                }
            }

            context.Prisoners.AddRange(prisoners);
            context.SaveChanges();

            var result = sb.ToString();
            return result;
        }

        public static string ImportOfficersPrisoners(SoftJailDbContext context, string xmlString)
        {
            var sb = new StringBuilder();

            var serializer = new XmlSerializer(typeof(OfficerDto[]), new XmlRootAttribute(RootElementName));
            var deserializeOfficerPrisoners =
                (OfficerDto[])serializer.Deserialize(new StringReader(xmlString));

            var validOfficers = new List<Officer>();
            foreach (var officerPrisonerDto in deserializeOfficerPrisoners)
            {
                if (!IsValid(officerPrisonerDto))
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                bool hasInvalidPrisoners = false;
                var validPrisoners = new List<OfficerPrisoner>();
                foreach (var prisonerDto in officerPrisonerDto.Prisoners)
                {
                    if (!IsValid(prisonerDto))
                    {
                        hasInvalidPrisoners = true;
                        break;
                    }

                    var officerPrisoner = new OfficerPrisoner
                    {
                        PrisonerId = prisonerDto.Id,
                    };

                    validPrisoners.Add(officerPrisoner);
                }

                if (hasInvalidPrisoners)
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                var isPositionValid = Enum.TryParse(officerPrisonerDto.Position, out Position pos);
                var isWeaponValid = Enum.TryParse(officerPrisonerDto.Weapon, out Weapon weap);

                if (!isPositionValid || !isWeaponValid)
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                var officer = new Officer
                {
                    DepartmentId = officerPrisonerDto.DepartmentId,
                    FullName = officerPrisonerDto.Name,
                    Position = pos,
                    Salary = officerPrisonerDto.Money,
                    Weapon = weap,
                    OfficerPrisoners = validPrisoners,
                };

                validOfficers.Add(officer);
                sb.AppendLine($"Imported {officerPrisonerDto.Name} ({officerPrisonerDto.Prisoners.Length} prisoners)");
            }

            context.Officers.AddRange(validOfficers);
            context.SaveChanges();

            return sb.ToString();
        }

        private static bool IsValid(object obj)
        {
            var validationContext = new System.ComponentModel.DataAnnotations.ValidationContext(obj);
            var validationResults = new List<ValidationResult>();

            return Validator.TryValidateObject(obj, validationContext, validationResults, true);
        }
    }
}