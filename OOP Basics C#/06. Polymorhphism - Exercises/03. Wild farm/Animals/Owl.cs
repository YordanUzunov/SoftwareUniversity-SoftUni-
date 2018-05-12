﻿using System;

public class Owl : Bird
{
    public const double IncreaseWeightPercentage = 0.25;

    public Owl(string name, double weight, double wingSize)
        : base(name, weight, wingSize)
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
        return "Hoot Hoot";
    }
}
