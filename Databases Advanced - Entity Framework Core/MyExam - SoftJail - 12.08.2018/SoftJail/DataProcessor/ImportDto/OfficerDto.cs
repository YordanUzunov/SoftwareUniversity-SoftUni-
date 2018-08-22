﻿namespace SoftJail.DataProcessor.ImportDto
{
    using System.ComponentModel.DataAnnotations;
    using System.Xml.Serialization;

    using SoftJail.Data.Models.Enums;

    [XmlType("Officer")]
    public class OfficerDto
    {
        //    <Name>Minerva Kitchingman</Name>
        //<Money>2582</Money>
        //<Position>Invalid</Position>
        //<Weapon>ChainRifle</Weapon>
        //<DepartmentId>2</DepartmentId>
        //<Prisoners>
        //  <Prisoner id = "15" />
        //</ Prisoners >

        [Required]
        [StringLength(30, MinimumLength = 3)]
        public string Name { get; set; }

        [Required]
        [Range(typeof(decimal), "0.00", "79228162514264337593543950335")]
        public decimal Money { get; set; }

        [Required]
        public string Position { get; set; }

        [Required]
        public string Weapon { get; set; }

        [Required]
        [Range(1, int.MaxValue)]
        public int DepartmentId { get; set; }

        public OfficerPrisonerDto[]  Prisoners { get; set; }
    }
}
