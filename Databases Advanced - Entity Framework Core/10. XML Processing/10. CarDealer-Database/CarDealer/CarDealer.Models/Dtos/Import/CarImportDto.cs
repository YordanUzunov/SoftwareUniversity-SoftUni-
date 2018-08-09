namespace CarDealer.Models.Dtos.Import
{
    using System.Xml.Serialization;

    [XmlType("car")]
    public class CarImportDto
    {
        [XmlElement("make")]
        public string Make { get; set; }

        [XmlElement("model")]
        public string Model { get; set; }

        [XmlElement("travelled-distance")]
        public long Distance { get; set; }
    }
}
