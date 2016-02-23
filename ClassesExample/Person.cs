using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesExample
{
    public class Person
    {
        public Person(string firstName, string lastName, int age, Address address, Vehicle car)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.Address = address;
            this.Car = car;
        }

        public Person(string firstName, string lastName, Address address, Vehicle car)
            : this(firstName, lastName, -1, address, car)
        {
        }

        public Person(string firstName, string lastName, int age)
            : this(firstName, lastName, age, null, null)
        {
        }

        public Person(string firstName, string lastName)
            : this(firstName, lastName, -1)
        {
        }


        private string firstName;
        private string lastName;
        private int age;

        public string FullName
        {
            get
            {
                return firstName + " " + lastName;
            }
        }

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value < 0)
                    throw new Exception($"invalid age value of {value}");
                age = value;
            }

        }

        public Address Address { get; set; }
        public Vehicle Car { get; set; }
    }
}
