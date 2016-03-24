using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotrEntities.Armors
{
    public interface IArmor
    {
        int Defense { get; set; }
        ArmorType Type { get; }
    }
}
