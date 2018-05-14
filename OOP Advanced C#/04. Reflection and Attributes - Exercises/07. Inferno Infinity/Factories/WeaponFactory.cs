namespace P07_InfernoInfinity.Factories
{
    using System;
    using Enums;
    using Interfaces;
    using Models.Weapons;

    public class WeaponFactory
    {
        public IWeapon CreateWeapon(string type, string name, string weaponRarity)
        {
            WeaponRarity rarity;
            var isRarityValid = Enum.TryParse(weaponRarity, out rarity);

            if (!isRarityValid)
            {
                return null;
            }

            switch (type)
            {
                case "Axe":
                    return new Axe(name, rarity);
                case "Sword":
                    return new Sword(name, rarity);
                case "Knife":
                    return new Knife(name, rarity);
                default:
                    return null;
            }
        }
    }
}
