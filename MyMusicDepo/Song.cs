using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMusicDepo
{
    public class Song
    {
        public int ID { get; set; }
        public int AlbumID { get; set; }

        public string Name { get; set; }
        public int Length { get; set; }

        public override string ToString()
        {
            return $"#{ID} - #{AlbumID} - {Name} - {Length}";
        }

    }
}
