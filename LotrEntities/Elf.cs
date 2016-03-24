using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotrEntities
{
    public class Elf : IMortal
    {
        public int HealthPoints { get; set; }
        public int Height { get; set; }
        public string Name { get; set; }

        public bool IsAlive
        {
            get
            {
                return HealthPoints > 0;
            }
        }


        public override string ToString()
        {
            return $"{Name} ({HealthPoints})";
        }

    }
}
