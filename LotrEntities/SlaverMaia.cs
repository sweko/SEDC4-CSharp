using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotrEntities
{
    public class SlaverMaia : Maia, IUrukHaiMaster
    {
        public IEnumerable<UrukHai> Slaves { get; set; }
    }
}
