using System;

namespace MovieClasses
{
    public class Person
    {
        public Person() {
            Gender = Gender.Unknown;
        }

        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }

        public Gender Gender { get; set; }
        public bool? IsAlive { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}