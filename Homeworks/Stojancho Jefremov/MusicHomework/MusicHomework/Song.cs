using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicHomework
{
    public class Song : BaseMusicEntity
    {
        public ushort Duration { get; set; }

        public int AlbumId { get; set; }
    }
}
