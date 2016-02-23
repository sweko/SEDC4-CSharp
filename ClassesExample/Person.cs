using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesExample
{
    public class Person
    {
        public Person(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }

        public Person(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = -1;
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


    }
}
