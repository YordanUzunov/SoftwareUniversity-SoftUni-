namespace PetClinic.DataProcessor.Dto.ImportDto
{
    using System.Xml.Serialization;

    [XmlType("AnimalAid")]
    public class AnimalAidProcedureDto
    {
        public string Name { get; set; }
    }
}
