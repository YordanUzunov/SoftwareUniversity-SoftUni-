using System;

public class Tesla : ICar, IElectricCar
{
    public Tesla(string model, string color, int batteries)
    {
        this.Model = model;
        this.Color = color;
        this.Batteries = batteries;
    }

    public int Batteries { get; private set; }

    public string Model { get; private set; }

    public string Color { get; private set; }

    public string Start()
    {
        return "Breaaak!";
    }

    public string Stop()
    {
        return "Skrrrrrt";
    }

    public override string ToString()
    {
        return $"{this.Color} {nameof(Tesla)} {this.Model} with {this.Batteries} Batteries" + Environment.NewLine +
               "Engine start" + Environment.NewLine +
               $"{this.Start()}";
    }
}
