using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkClasses
{
    class Person
    {

        public Person(string firstName, string lastName, Address address, Vehicle vehicle)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Address = address;
            this.Vehicle = vehicle;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Address Address { get; set; }
        public Vehicle Vehicle { get; set; }

        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
            set
            {

            }
        }
    }
}
