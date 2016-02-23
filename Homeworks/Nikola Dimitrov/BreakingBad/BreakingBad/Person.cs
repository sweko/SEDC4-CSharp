using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakingBad
{
    public class Person
    {
        public Person (string firstName)
        {
            this.firstName = firstName;           
        }

        private string firstName;
        private string lastName;
        private int age;
       

        public string FullName
        {
            get
            {
                if (firstName == "Walter" || firstName == "Skyler")
                {
                    lastName = "White";
                }
                else if (firstName == "Jesse")
                {
                    lastName = "Pinkman";
                }
                else if (firstName == "Hank")
                {
                    lastName = "Schrader";
                }
                else if (firstName == "Saul")
                {
                    lastName = "Goodman";
                }
                return firstName + " " + lastName;
            }
        }

        public int Age
        {
            get
            {
                if (firstName == "Walter")
                {
                    age = 50;
                }
                else if (firstName == "Jesse")
                {
                    age = 27;
                }
                else if (firstName == "Hank")
                {
                    age = 43;
                }
                else if (firstName == "Skyler")
                {
                    age = 45;
                }
                else if (firstName == "Saul")
                {
                    age = 40;
                }
                return age;
            }         
        }     
    }
}
