namespace PetClinic.DataProcessor
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Xml.Serialization;
    using AutoMapper;
    using Newtonsoft.Json;

    using PetClinic.Data;
    using PetClinic.DataProcessor.Dto.ImportDto;
    using PetClinic.Models;

    public class Deserializer
    {
        private const string ErrorMessage = "Error: Invalid data.";

        public static string ImportAnimalAids(PetClinicContext context, string jsonString)
        {
            var sb = new StringBuilder();

            var deserializedJson = JsonConvert.DeserializeObject<AnimalAidDto[]>(jsonString);

            var validAnimalAids = new List<AnimalAid>();

            foreach (var animalAidDto in deserializedJson)
            {
                var animalAidExists = validAnimalAids.Any(ai => ai.Name == animalAidDto.Name);

                if (!IsValid(animalAidDto) || animalAidExists)
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                var animalAid = Mapper.Map<AnimalAid>(animalAidDto);
                validAnimalAids.Add(animalAid);

                sb.AppendLine($"Record {animalAidDto.Name} successfully imported.");
            }

            context.AnimalAids.AddRange(validAnimalAids);
            context.SaveChanges();

            var result = sb.ToString();
            return result;

        }

        public static string ImportAnimals(PetClinicContext context, string jsonString)
        {
            var sb = new StringBuilder();

            var deserializedJson = JsonConvert.DeserializeObject<AnimalDto[]>(jsonString);

            var validAnimals = new List<Animal>();

            foreach (var animalDto in deserializedJson)
            {
                var passportSerialNumberExists = validAnimals.Any(p => p.Passport.SerialNumber == animalDto.Passport.SerialNumber);

                if (!IsValid(animalDto) || !IsValid(animalDto.Passport) || passportSerialNumberExists)
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                var animal = Mapper.Map<Animal>(animalDto);
                validAnimals.Add(animal);
                sb.AppendLine($"Record {animalDto.Name} Passport №: {animalDto.Passport.SerialNumber} successfully imported.");
            }

            context.Animals.AddRange(validAnimals);
            context.SaveChanges();

            var result = sb.ToString();
            return result;
        }

        public static string ImportVets(PetClinicContext context, string xmlString)
        {
            var sb = new StringBuilder();

            var serializer = new XmlSerializer(typeof(VetDto[]), new XmlRootAttribute("Vets"));
            var deserializedXml = (VetDto[])serializer.Deserialize(new StringReader(xmlString));

            var validVets = new List<Vet>();

            foreach (var vetDto in deserializedXml)
            {
                var vetPhoneNumberExists = validVets.Any(x => x.PhoneNumber == vetDto.PhoneNumber);

                if (!IsValid(vetDto) || vetPhoneNumberExists)
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                var vet = Mapper.Map<Vet>(vetDto);
                validVets.Add(vet);
                sb.AppendLine($"Record {vetDto.Name} successfully imported.");
            }

            context.Vets.AddRange(validVets);
            context.SaveChanges();

            var result = sb.ToString();
            return result;
        }

        public static string ImportProcedures(PetClinicContext context, string xmlString)
        {
            var sb = new StringBuilder();

            var serializer = new XmlSerializer(typeof(ProcedureDto[]), new XmlRootAttribute("Procedures"));
            var deserializedXml = (ProcedureDto[])serializer.Deserialize(new StringReader(xmlString));

            var validProcedures = new List<Procedure>();

            foreach (var procedureDto in deserializedXml)
            {
                var vetObj = context.Vets.SingleOrDefault(x => x.Name == procedureDto.Vet);
                var animalObj = context.Animals.SingleOrDefault(a => a.PassportSerialNumber == procedureDto.Animal);

                var validProcedureAnimalAids = new List<ProcedureAnimalAid>();

                var allAidsExists = true;

                foreach (var procedureDtoAnimalAid in procedureDto.AnimalAids)
                {
                    var animalAid = context.AnimalAids
                        .SingleOrDefault(ai => ai.Name == procedureDtoAnimalAid.Name);
                    if (animalAid == null || validProcedureAnimalAids.Any(p => p.AnimalAid.Name == procedureDtoAnimalAid.Name))
                    {
                        allAidsExists = false;
                        break;
                    }

                    var animalAidProcedure = new ProcedureAnimalAid()
                    {
                        AnimalAid = animalAid
                    };

                    validProcedureAnimalAids.Add(animalAidProcedure);
                }

                if (!IsValid(procedureDto) || !procedureDto.AnimalAids.All(IsValid) 
                    || vetObj == null || animalObj == null || !allAidsExists)
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                var procedure = new Procedure()
                {
                    Animal = animalObj,
                    Vet = vetObj,
                    DateTime = DateTime.ParseExact(procedureDto.DateTime, "dd-MM-yyyy", CultureInfo.InvariantCulture),
                    ProcedureAnimalAids = validProcedureAnimalAids
                };
                validProcedures.Add(procedure);
                sb.AppendLine("Record successfully imported.");
            }
            context.Procedures.AddRange(validProcedures);
            context.SaveChanges();

            var result = sb.ToString();
            return result;

        }

        private static bool IsValid(object obj)
        {
            var context = new System.ComponentModel.DataAnnotations.ValidationContext(obj);
            var results = new List<ValidationResult>();

            var isValid = Validator.TryValidateObject(obj, context, results, true);

            return isValid;
        }
    }
}
