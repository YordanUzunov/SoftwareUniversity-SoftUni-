using System;
using System.Collections.Generic;

public class Mouse : Mammal
{
    public const double IncreaseWeightPercentage = 0.10;

    public Mouse(string name, double weight, string livingRegion)
        : base(name, weight, livingRegion)
    {
    }

    public override void IncreaseWeight(Food food)
    {
        if (food.GetType().Name == "Vegetable" || food.GetType().Name == "Fruit")
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
        return "Squeak";
    }

    public override string ToString()
    {
        return $"{base.ToString()}{this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
    }
}

