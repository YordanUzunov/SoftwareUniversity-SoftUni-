namespace ProductShop.App.Dto.UsersAndProducts4thQuery
{
    using System.Xml.Serialization;

    [XmlType("product")]
    public class ProductDto4
    {
        [XmlAttribute("name")]
        public string Name { get; set; }

        [XmlAttribute("price")]
        public decimal Price { get; set; }
    }
}
