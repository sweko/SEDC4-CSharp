using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Person weko = new Person
            {
                FirstName = "Wekoslav",
                LastName = "Stefanovski",
                Gender = Gender.Male
            };

            Person invalid = new Person()
            {
                FirstName = "Invalid",
                LastName = "Invalidson",
                Gender = (Gender)(-1)
            };

            Person female = new Person()
            {
                FirstName = "Femala",
                LastName = "Femalson",
                Gender = Gender.Female
            };


            Console.WriteLine(weko.GetGenderDescription());
            Console.WriteLine(female.GetGenderDescription());
            // Console.WriteLine(invalid.GetGenderDescription());
            //"{fullname} is male and has testosterone";
            //"{fullname} is female and has estrogene";
            //"{fullname} has not declared itself as male or female";
            //"We have no idea what {fullname}'s gender is";
        }
    }
}
