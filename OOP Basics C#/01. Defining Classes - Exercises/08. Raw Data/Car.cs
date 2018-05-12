using System;

public class Car
{
    public Car(string model, Engine engine, Cargo cargo, Tire[] tires)
    {
        if (tires.Length != 4)
        {
            throw new InvalidOperationException("Tires can not be no more neither less than 4!!!");
        }

        this.Model = model;
        this.Engine = engine;
        this.Cargo = cargo;
        this.Tires = tires;
    }

    public string Model { get; }

    public Engine Engine { get; }

    public Cargo Cargo { get; }

    public Tire[] Tires { get; }
}
