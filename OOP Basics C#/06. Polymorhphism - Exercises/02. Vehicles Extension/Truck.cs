public class Truck : Vehicle
{
    private const double TakenFuelInCharging = 0.95;

    public Truck(double fuelAmount, double fuelConsumption, double airConditioningConsumption, double fuelTankCapacity)
        : base(fuelAmount, fuelConsumption, airConditioningConsumption, fuelTankCapacity)
    {
    }

    public override void Refuel(double fuel)
    {
        fuel *= TakenFuelInCharging;
        base.Refuel(fuel);
    }
}