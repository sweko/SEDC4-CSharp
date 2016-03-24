using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotrEntities.Weapons
{
    public interface IWeapon
    {
        int Damage { get; }
        int Range { get;  }
        DamageType Type { get; }
    }
}
