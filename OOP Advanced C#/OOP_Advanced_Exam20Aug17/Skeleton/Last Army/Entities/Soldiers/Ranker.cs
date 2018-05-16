﻿using System.Collections.Generic;

public class Ranker : Soldier
{
    private const double overallSkillMiltiplier = 1.5;
    protected override double OverallSkillMultiplier => overallSkillMiltiplier;

    private readonly List<string> weaponsAllowed = new List<string>
        {
            "Gun",
            "AutomaticMachine",
            "Helmet",
        };

    protected override List<string> WeaponsAllowed => weaponsAllowed;

    public Ranker(string name, int age, double experience, double endurance)
        : base(name, age, experience, endurance)
    {
    }
}

