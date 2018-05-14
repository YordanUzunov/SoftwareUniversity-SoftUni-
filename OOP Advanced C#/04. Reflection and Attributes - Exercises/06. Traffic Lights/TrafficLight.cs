using System;

public class TrafficLight
{
    private readonly int lightsCount;

    public TrafficLight(TLightColor light)
    {
        this.Light = light;
        this.lightsCount = Enum.GetNames(typeof(TLightColor)).Length;
    }

    public TLightColor Light { get; private set; }

    public void ChangeLight()
    {
        var nextValue = (int)this.Light + 1;
        if (nextValue == this.lightsCount)
        {
            nextValue = 0;
        }

        var nextLight = (TLightColor)nextValue;
        this.Light = nextLight;
    }
}

