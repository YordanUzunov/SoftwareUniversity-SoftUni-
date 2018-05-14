using System;

public class Seat : ICar
{

    public Seat(string model, string color)
    {
        this.Model = model;
        this.Color = color;
    }

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
        return $"{this.Color} {nameof(Seat)} {this.Model}" + Environment.NewLine +
               "Engine start" + Environment.NewLine +
               $"{this.Start()}";
    }
}
