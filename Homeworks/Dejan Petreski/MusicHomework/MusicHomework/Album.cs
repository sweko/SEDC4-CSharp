using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicHomework
{
    class Album
    {
        public int ID { get; set; }
        public string AlbumName { get; set; }
        public int AlbumYear { get; set; }
        public int ArtistID { get; set; }
        public IEnumerable<int> SongIds { get; set; }
    }
}
