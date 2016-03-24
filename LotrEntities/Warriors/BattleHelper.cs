using LotrEntities.Armors;
using LotrEntities.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotrEntities.Warriors
{
    public static class BattleHelper
    {
        public static ArmorType GetNeededArmorType(IWeapon weapon)
        {
            if (weapon.Type == DamageType.Magical)
                return ArmorType.Magical;
            if (weapon.Range == 0)
                return ArmorType.Physical;
            return ArmorType.Ranged;
        }
    }
}
