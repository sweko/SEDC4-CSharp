using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotrEntities
{
    public class Hobbit : Human
    {
        public HobbitClan Clan { get; set; }

        public override int Height
        {
            get
            {
                return base.Height;
            }

            set
            {
                if (value > 120)
                    value = 120;
                base.Height = value;
            }
        }

        public override string ToString()
        {
            return $"{Name} of the {Clan} ({HealthPoints})";
        }

    }
}
