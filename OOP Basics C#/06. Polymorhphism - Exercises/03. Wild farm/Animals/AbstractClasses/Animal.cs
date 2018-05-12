using System;

public abstract class Animal : IAnimal
{
    public Animal(string name, double weight)
    {
        this.Name = name;
        this.Weight = weight;
        //this.FoodEaten = 0;
    }

    public string Name { get; protected set; }
    public double Weight { get; protected set; }
    public int FoodEaten { get; protected set; } = 0;

    public abstract void IncreaseWeight(Food food);

    public abstract string ProduceSound();

    public override string ToString()
    {
        return $"{this.GetType().Name} [{this.Name}, ";
    }
}

