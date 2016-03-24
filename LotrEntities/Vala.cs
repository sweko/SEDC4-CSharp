using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotrEntities
{
    public class Vala : IUrukHaiMaster
    {
        public string Name { get; set; }

        public override string ToString()
        {
            return $"The vala {Name}";
        }
    }
}
