namespace ProductShop.App.Dto.Export
{
    using System.Xml.Serialization;

    [XmlType("product")]
    public class ProductDto
    {
        [XmlAttribute("name")]
        public string Name { get; set; }

        [XmlAttribute("price")]
        public decimal Price { get; set; }

        [XmlAttribute("buyer")]
        public string Buyer { get; set; }
    }
}
