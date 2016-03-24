using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotrEntities.Weapons
{
    public class Sword : IWeapon
    {
        public Sword(int damage)
        {
            Damage = damage;
        }

        public int Damage { get; set; }

        public int Range
        {
            get
            {
                return 0;
            }
        }

        public DamageType Type
        {
            get
            {
                return DamageType.Physical;
            }
        }
    }
}
