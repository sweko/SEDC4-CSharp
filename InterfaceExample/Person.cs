using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    public class Person : IEquatable<Person>
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public bool Equals(Person other)
        {
            //if (ID != other.ID)
            //    return false;
            if (FirstName != other.FirstName)
                return false;
            if (LastName != other.LastName)
                return false;
            return true;
        }
    }
}
