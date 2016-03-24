using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotrEntities
{
    public interface IMortal
    {
        string Name { get; set; }
        int HealthPoints { get; set; }
        int Height { get; set; }

        bool IsAlive { get; }
    }
}
