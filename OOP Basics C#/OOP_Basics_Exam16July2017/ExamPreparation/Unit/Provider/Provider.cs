﻿using System;

public abstract class Provider: Unit
{
    const double MaxEnergyOutput = 10_000;
    private double energyOutput;

    public double EnergyOutput
    {
        get { return energyOutput; }
        private set
        {
            if (value < 0 || value >= MaxEnergyOutput)
            {
                throw new ArgumentException("Provider is not registered, because of it's EnergyOutput");
            }
            energyOutput = value;
        }
    }

    protected Provider(string id, double energyOutput):base(id)
    {
        EnergyOutput = energyOutput;
    }

    public override string ToString()
    {
        return $"{Type} Provider - {Id}" + Environment.NewLine +
               $"Energy Output: {EnergyOutput}";
    }
}