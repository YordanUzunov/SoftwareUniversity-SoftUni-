using Newtonsoft.Json;

namespace CarDealer.Models.Dtos.Export
{
    public class CarsAndTheirPartsExportDto
    {
        [JsonProperty("car")]
        public CarWithDistanceExportDto Car { get; set; }

        [JsonProperty("parts")]
        public PartsForCarExportDto[] Parts { get; set; }
    }
}
