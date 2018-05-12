public class Engine
{
    public Engine(int speed, int power)
    {
        this.Speed = speed;
        this.Power = power;
    }

    public int Power { get; }

    public int Speed { get; }
}