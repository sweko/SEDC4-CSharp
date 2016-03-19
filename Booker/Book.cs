using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booker
{
    public class Book
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public int PageCount { get; set; }

        public int AuthorID { get; set; }

        public override string ToString()
        {
            return $"#{ID} {Title}";
        }
    }
}
