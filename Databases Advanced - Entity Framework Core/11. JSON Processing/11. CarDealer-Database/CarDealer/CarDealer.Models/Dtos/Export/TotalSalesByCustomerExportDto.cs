namespace CarDealer.Models.Dtos.Export
{
    using Newtonsoft.Json;
    using System.Linq;

    public class TotalSalesByCustomerExportDto
    {
        [JsonProperty("fullName")]
        public string FullName { get; set; }

        [JsonProperty("boughtCars")]
        public int CarsCount { get; set; }

        [JsonProperty("spentMoney")]
        public string MoneySpent
        {
            get
            {
                return this.PriceAndDiscounts.Sum(c => c.TotalPrice - (c.TotalPrice * (decimal)c.Discount)).ToString("F2");
            }
            set { this.MoneySpent = value; }
        }

        [JsonIgnore]
        public CarPriceAndDiscountExportDto[] PriceAndDiscounts { get; set; }
    }
}
