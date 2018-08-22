﻿namespace ProductShop.App.Dto.Export
{
    using System.Xml.Serialization;

    [XmlType("product")]
    public class SoldProduct
    {
        [XmlElement("name")]
        public string Name { get; set; }

        [XmlElement("price")]
        public decimal Price { get; set; }
    }
}