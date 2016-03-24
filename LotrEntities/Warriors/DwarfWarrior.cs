using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LotrEntities.Armors;
using LotrEntities.Weapons;

namespace LotrEntities.Warriors
{
    public class DwarfWarrior : Dwarf, IWarrior
    {
        public IArmor MainArmor { get; set; }

        public IArmor SideArmor { get; set; }

        private Sword weapon;
        public IWeapon Weapon
        {
            get
            {
                return weapon;
            }
            set
            {
                if (value is Sword)
                {
                    weapon = (Sword)value;
                    return;
                }
                throw new ArgumentException("value");
            }
        }


        public void Attack(IWarrior target)
        {
            Random r = new Random();
            List<IArmor> armors = new List<IArmor> { target.MainArmor, target.SideArmor };
            var defense = armors
                .Where(a => a != null && a.Type == ArmorType.Physical)
                .Sum(a => a.Defense);

            var actualDamage = weapon.Damage - defense;
            target.HealthPoints -= (int)(actualDamage * (0.9+r.NextDouble()*0.2));
        }
    }
}
