using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotrEntities.Weapons
{
    public class Bow : IWeapon
    {
        public Bow(int damage, int range)
        {
            Damage = damage;
            Range = range;
        }

        public int Damage { get; set; }
        public int Range { get; set; }

        public DamageType Type
        {
            get
            {
                return DamageType.Physical;
            }
        }
    }
}
