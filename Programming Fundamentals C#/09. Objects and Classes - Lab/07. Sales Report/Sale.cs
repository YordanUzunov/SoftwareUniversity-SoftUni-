public class Sale
{
    public Sale(string town, decimal money)
    {
        this.Town = town;
        this.Money = money;
    }

    public string Town { get; }
    public decimal Money { get; set; }
}

