using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotrEntities.Armors
{
    public class MagicalNecklace: IArmor
    {
        public int Defense { get; set; }

        public ArmorType Type
        {
            get
            {
                return ArmorType.Magical;
            }
        }
    }
}
