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

            Console.WriteLine(weko.GetGenderDescription());
            //"{fullname} is male and has testosterone";
            //"{fullname} is female and has estrogene";
            //"{fullname} has not declared itself as male or female";
            //"We have no idea what {fullname}'s gender is";
        }
    }
}
