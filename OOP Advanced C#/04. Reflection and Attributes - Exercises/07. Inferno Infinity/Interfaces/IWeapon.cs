namespace P07_InfernoInfinity.Interfaces
{
    using Enums;

    public interface IWeapon
    {
        WeaponRarity Rarity { get; }

        string Name { get; }

        int MinDamage { get; }

        int MaxDamage { get; }

        IGem[] GemSockets { get; }

        void AddGem(IGem gem, int socketIndex);

        void RemoveGem(int socketIndex);
    }
}
