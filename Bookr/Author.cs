using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookr
{
    class Author
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return $"{ID} - {Name}";
        }
    }
}
