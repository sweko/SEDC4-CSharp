using System;

namespace MovieClasses
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }

        public Gender Gender { get; set; }
        public bool? IsAlive { get; set; }
    }
}