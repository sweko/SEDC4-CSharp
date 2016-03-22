using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMusicDepo
{
    public class Album
    {
        public int ID { get; set; }
        public int ArtistID { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }

        public override string ToString()
        {
            return $"#{ID} - #{ArtistID} - {Name} - {Year}";
        }
    }
}
