using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakingBad
{
    class Person
    {
        private string firstName;
        private string lastName;
        private int age;

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
            set
            {
                string[] names = value.Split(' ');
                if (names.Length != 2) throw new Exception($"{value} not in format 'FirstName LastName'.");
                firstName = names[0];
                lastName = names[1];
            }
        }

        public int Age
        {
            get { return age; }
            set
            {
                if (value < 0) throw new Exception($"Invalid age value of {value}.");
                this.age = value;
            }
        }

        public Address Address { get; set; }
        public Vehicle Vehicle { get; set; }

        public Person(string firstName, string lastName, int age, Address address, Vehicle vehicle)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Address = address;
            Vehicle = vehicle;
        }
    }
}
