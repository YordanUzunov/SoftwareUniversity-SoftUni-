using System;

public class Dog : Mammal
{
    public const double IncreaseWeightPercentage = 0.40;

    public Dog(string name, double weight, string livingRegion)
        : base(name, weight, livingRegion)
    {
    }

    public override void IncreaseWeight(Food food)
    {
        if (food.GetType().Name == "Meat")
        {
            this.Weight += food.Quantity * IncreaseWeightPercentage;
            this.FoodEaten += food.Quantity;
        }
        else
        {
            throw new ArgumentException($"{this.GetType().Name} does not eat {food.GetType().Name}!");
        }
    }

    public override string ProduceSound()
    {
        return "Woof!";
    }

    public override string ToString()
    {
        return $"{base.ToString()}{this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
    }
}
