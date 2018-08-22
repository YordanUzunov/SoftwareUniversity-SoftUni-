using System.ComponentModel.DataAnnotations;

namespace SoftJail.DataProcessor.ExportDto
{
    public class OfficerDto
    {
        [Required]
        [StringLength(30, MinimumLength = 3)]
        public string OfficerName { get; set; }

        [Required]
        [StringLength(25, MinimumLength = 3)]
        public string Department { get; set; }
    }
}
