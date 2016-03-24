using System.Collections.Generic;

namespace LotrEntities
{
    public interface IUrukHaiMaster
    {
        string Name { get; }
        IEnumerable<UrukHai> Slaves { get; set; }
    }
}