using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieClasses
{
    public class Movie
    {
        public string Title { get; set; }
        public int Year { get; set; }
        public TimeSpan Duration { get; set; }
        public List<Genre> Genres { get; set; }
        public Person Director { get; set; }
        public List<Person> Cast { get; set; }
    }
}
