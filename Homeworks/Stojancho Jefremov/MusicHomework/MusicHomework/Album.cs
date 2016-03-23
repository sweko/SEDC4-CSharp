using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicHomework
{
    public class Album : BaseMusicEntity
    {
        public ushort Year { get; set; }

        public int ArtistId { get; set; }
        
    }
}
