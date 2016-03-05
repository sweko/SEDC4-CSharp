using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictExample
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }

        public string GetGenderDescription()
        {
            switch (Gender)
            {
                case Gender.Male:
                    return $"{FirstName} {LastName} is male and has testosterone";
                case Gender.Female:
                    return $"{FirstName} {LastName} is female and has estrogene";
                case Gender.Other:
                    return $"{FirstName} {LastName} has not declared itself as male or female";
                case Gender.Undefined:
                    return $"We have no idea what {FirstName} {LastName}'s gender is";
                default:
                    throw new Exception($"Gender value of {Gender} is not a valid gender");
            }
        }
    }
}
