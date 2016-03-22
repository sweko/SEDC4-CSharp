using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicHomework
{
    public abstract class BaseMusicEntity
    {
        public ushort Id { get; set; }

        public string Name { get; set; }

        public override string ToString()
        {
            return "#" + Id + " " + Name;
        }
    }
}
