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
            set
            {
                var indexOfSpace = value.IndexOf(" ");
                if (indexOfSpace > -1)
                {
                    this.firstName = value.Substring(0, indexOfSpace);
                    this.lastName = value.Substring(indexOfSpace + 1);
                }
                else
                {
                    throw new Exception($@"The value for FullName must be composed of values 
                        for FirstName and LastName divided with space! Current value: {value}");
                }
            }
        }

        public int Age {
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

        public string FirstName
        {
            get
            {
                return firstName;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }
        }

        public Vehicle Vehicle { get; set; }

        public override string ToString()
        {
            var result = "";
            result += "Full name: " + FullName;
            result += " Age: " + Age;
            result += " Vehicle: " + Vehicle;
            return result;
        }
    }
}
