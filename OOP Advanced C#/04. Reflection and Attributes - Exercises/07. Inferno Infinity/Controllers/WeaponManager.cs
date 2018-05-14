namespace P07_InfernoInfinity.Controllers
{
    using Factories;
    using Interfaces;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class WeaponManager
    {
        private IList<IWeapon> weapons;
        private WeaponFactory weaponFactory;

        public WeaponManager()
        {
            this.weapons = new List<IWeapon>();
            this.weaponFactory = new WeaponFactory();
        }

        public void CreateWeapon(string weaponType, string weaponName, string weaponRarity)
        {
            var weapon = this.weaponFactory.CreateWeapon(weaponType, weaponName, weaponRarity);
            if (weapon != null)
            {
                this.weapons.Add(weapon);
            }
        }

        public string GetAllWeapons()
        {
            var sb = new StringBuilder();

            foreach (var weapon in this.weapons)
            {
                sb.AppendLine(weapon.ToString());
            }

            return sb.ToString().TrimEnd();
        }

        public void AddGemToWeapon(string weaponName, int socketIndex, IGem gem)
           => this.GetWeapon(weaponName)?.AddGem(gem, socketIndex);

        public void RemoveGemFromWeapon(string weaponName, int socketIndex)
            => this.GetWeapon(weaponName)?.RemoveGem(socketIndex);

        public IWeapon GetWeapon(string weaponName)
            => this.weapons.FirstOrDefault(w => w.Name == weaponName);
    }
}
