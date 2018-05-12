using System;

public class Car
{
    public Car(string model, double fuelAmount, double fuelConsumptionPerKm)
    {
        this.Model = model;
        this.FuelAmount = fuelAmount;
        this.FuelConsumptionPerKm = fuelConsumptionPerKm;
        this.DistanceTravelled = 0.0;
    }

    public string Model { get; }

    public double FuelAmount { get; set; }

    public double FuelConsumptionPerKm { get; }

    public double DistanceTravelled { get; set; }

    public void Drive(double kilometers)
    {
        var neededFuel = kilometers * this.FuelConsumptionPerKm;

        if (this.FuelAmount < neededFuel)
        {
            Console.WriteLine("Insufficient fuel for the drive");
            return;
        }

        this.FuelAmount -= neededFuel;
        this.DistanceTravelled += kilometers;
    }
}
