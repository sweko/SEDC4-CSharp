using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotrEntities.Armors
{
    public class Shield : IArmor
    {
        public int Defense { get; set; }

        public ArmorType Type
        {
            get
            {
                return ArmorType.Ranged;
            }
        }
    }
}
