namespace ProductShop.App.Dto.UsersAndProducts4thQuery
{
    using System.Xml.Serialization;

    [XmlType("user")]
    public class UserDto4
    {
        [XmlAttribute("first-name")]
        public string FirstName { get; set; }

        [XmlAttribute("last-name")]
        public string LastName { get; set; }

        [XmlAttribute("age")]
        public string Age { get; set; }

        [XmlElement("sold-products")]
        public SoldProduct4 SoldProducts { get; set; }
    }
}
