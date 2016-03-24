using LotrEntities.Armors;
using LotrEntities.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotrEntities.Warriors
{
    public interface IWarrior
    {
        IArmor MainArmor { get; set; }
        IArmor SideArmor { get; set; }
        IWeapon Weapon { get; set; }
        int HealthPoints { get; set; }

        bool IsAlive { get;  }

        void Attack(IWarrior target);
    }
}
