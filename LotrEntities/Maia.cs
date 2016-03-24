using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotrEntities
{
    public class Maia
    {
        public Vala Master { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }

        public override string ToString()
        {
            return $"The maia {Name} the {Color} that serves the vala {Master.Name}";
        }
    }
}
