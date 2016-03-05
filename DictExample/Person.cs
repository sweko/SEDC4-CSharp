using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictExample
{
    public class Person
    {
        static Dictionary<Gender, string> GenderDescriptions;

        static Person()
        {
            GenderDescriptions = new Dictionary<Gender, string>();
            GenderDescriptions.Add(Gender.Male, "{0} is male and has testosterone");
            GenderDescriptions.Add(Gender.Female, "{0} is female and has estrogene");
            GenderDescriptions.Add(Gender.Undefined, "We have no idea what {0}'s gender is");
            GenderDescriptions.Add(Gender.Other, "{0} has not declared itself as male or female");
        }

        public Person()
        {

        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }

        public string GetGenderDescription()
        {
            if (!GenderDescriptions.ContainsKey(Gender))
            {
                throw new Exception($"Gender value of {Gender} is not a valid gender");
            }

            var format = GenderDescriptions[Gender];
            return string.Format(format, $"{FirstName} {LastName}");

            //switch (Gender)
            //{
            //    case Gender.Male:
            //        return $"{FirstName} {LastName} is male and has testosterone";
            //    case Gender.Female:
            //        return $"{FirstName} {LastName} is female and has estrogene";
            //    case Gender.Other:
            //        return $"{FirstName} {LastName} has not declared itself as male or female";
            //    case Gender.Undefined:
            //        return $"We have no idea what {FirstName} {LastName}'s gender is";
            //    default:
            //        throw new Exception($"Gender value of {Gender} is not a valid gender");
            //}
        }
    }
}
