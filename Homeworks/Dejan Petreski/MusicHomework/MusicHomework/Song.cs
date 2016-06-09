    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicHomework
{
    class Song
    {
        public int ID { get; set; }
        public string SongName { get; set; }
        public TimeSpan SongDuration { get; set; }
        public int AlbumID { get; set; }
    }
}
