using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicHomework
{
    public class Artist : BaseMusicEntity
    {
        public IEnumerable<int> AlbumIds { get; set; }
    }
}
