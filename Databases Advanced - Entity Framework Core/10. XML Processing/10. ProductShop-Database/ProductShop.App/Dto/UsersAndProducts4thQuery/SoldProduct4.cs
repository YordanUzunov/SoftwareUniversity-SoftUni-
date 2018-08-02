namespace ProductShop.App.Dto.UsersAndProducts4thQuery
{
    using System.Xml.Serialization;

    [XmlType("sold-product")]
    public class SoldProduct4
    {
        [XmlAttribute("count")]
        public int Count { get; set; }

        [XmlElement("product")]
        public ProductDto4[] ProductDto { get; set; }
    }
}
