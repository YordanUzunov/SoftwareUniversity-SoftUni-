﻿namespace CarDealer.Models.Dtos.Export
{
    using System.Xml.Serialization;

    [XmlType("part")]
    public class PartsForCarExportDto
    {
        [XmlAttribute("name")]
        public string Name { get; set; }

        [XmlAttribute("price")]
        public decimal Price { get; set; }
    }
}
