using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace SoftJail.DataProcessor.ExportDto
{
    public class PrisonerDto
    {
        public int Id { get; set; }

        [JsonProperty("Name")]
        [Required]
        [StringLength(20, MinimumLength = 3)]
        public string Name { get; set; }

        [Required]
        [Range(1, 1000)]
        public int CellNumber { get; set; }

        public OfficerDto[] Officers { get; set; }

        public decimal TotalOfficerSalary { get; set; }
    }
}
