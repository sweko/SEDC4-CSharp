using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotrEntities
{
    public class Human : IMortal
    {
        public int HealthPoints { get; set; }
        public virtual int Height { get; set; }
        public string Name { get; set; }

        public bool IsDead
        {
            get
            {
                return HealthPoints <= 0;
            }
        }

        public override string ToString()
        {
            return $"{Name} ({HealthPoints})";
        }

    }
}
