using System.Collections.Generic;

public class Hen : Bird
{
    public const double IncreaseWeightPercentage = 0.35;

    public Hen(string name, double weight, double wingSize)
        : base(name, weight, wingSize)
    {
    }

    public override void IncreaseWeight(Food food)
    {
        this.Weight += food.Quantity * IncreaseWeightPercentage;
        this.FoodEaten += food.Quantity;
    }


    public override string ProduceSound()
    {
        return "Cluck";
    }
}

