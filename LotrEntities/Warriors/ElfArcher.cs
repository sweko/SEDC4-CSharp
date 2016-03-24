using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LotrEntities.Armors;
using LotrEntities.Weapons;

namespace LotrEntities.Warriors
{
    public class ElfArcher : Elf, IWarrior
    {
        public IArmor MainArmor { get; set; }

        public IArmor SideArmor { get; set; }

        private Bow weapon;
        public IWeapon Weapon
        {
            get
            {
                return weapon;
            }
            set
            {
                if (value is Bow)
                {
                    weapon = (Bow)value;
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
                .Where(a => a != null && a.Type == ArmorType.Ranged)
                .Sum(a => a.Defense);

            var actualDamage = weapon.Damage - defense;
            target.HealthPoints -= (int)(actualDamage * (0.5+r.NextDouble()));
        }
    }
}
