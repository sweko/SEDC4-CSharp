using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booker
{
    public class Author
    {
        public int ID { get; set; }

        public string FirstName{ get; set; }
        public string LastName { get; set; }

        public IEnumerable<int> BookIds { get; set; }

        public override string ToString()
        {
            return $"#{ID} {FirstName} {LastName}";
        }
    }
}
