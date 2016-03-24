using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LotrEntities.Armors;
using LotrEntities.Weapons;

namespace LotrEntities.Warriors
{
    public class HobbitWarrior : Hobbit, IWarrior
    {
        public IArmor MainArmor { get; set; }

        public IArmor SideArmor { get; set; }
        public IWeapon Weapon { get; set; }

        public void Attack(IWarrior target)
        {
            var r = new Random();
            List<IArmor> armors = new List<IArmor> { target.MainArmor, target.SideArmor };
            var armorType = BattleHelper.GetNeededArmorType(Weapon);

            var defense = armors
                .Where(a => a != null && a.Type == armorType)
                .Sum(a => a.Defense);

            var critical = r.NextDouble() > 0.8;  

            var actualDamage = Weapon.Damage - defense;
            target.HealthPoints -= (int)(actualDamage * (0.8 + r.NextDouble())) * (critical ? 2 : 1);
        }
    }
}
