namespace ProductShop.App.Dto.Export
{
    using System.Xml.Serialization;

    [XmlType("user")]
    public class UserDto
    {
        [XmlAttribute("first-name")]
        public string FirstName { get; set; }

        [XmlAttribute("last-name")]
        public string LastName { get; set; }

        [XmlArray("sold-products")]
        public SoldProduct[] SoldProducts { get; set; }
    }
}
