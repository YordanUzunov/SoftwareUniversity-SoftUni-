namespace ProductShop.App.Dto.UsersAndProducts4thQuery
{
    using System.Xml.Serialization;

    [XmlRoot("users")]
    public class UsersDto4
    {
        [XmlAttribute("count")]
        public int Count { get; set; }

        [XmlElement("user")]
        public UserDto4[] Users { get; set; }
    }
}
