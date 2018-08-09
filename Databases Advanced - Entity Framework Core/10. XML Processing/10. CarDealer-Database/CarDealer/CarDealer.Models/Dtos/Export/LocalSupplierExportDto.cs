namespace CarDealer.Models.Dtos.Export
{
    using System.Xml.Serialization;

    [XmlType("suplier")]
    public class LocalSupplierExportDto
    {
        [XmlAttribute("id")]
        public int Id { get; set; }

        [XmlAttribute("name")]
        public string Name { get; set; }

        [XmlAttribute("parts-count")]
        public int Count { get; set; }
    }
}
