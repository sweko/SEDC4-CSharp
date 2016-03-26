using Dynamo;
using Reflect.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflect
{
    class Program
    {
        static void Main(string[] args)
        {
            var weko = new Entities.Person
            {
                FirstName = "Wekoslav",
                LastName = "Stefanovski",
                Age = 0x26,
                Address = "Kisela Voda, Skopje"
            };

            Type personType = weko.GetType();

            var props = personType.GetProperties();
            personType.GetMembers();

            Console.WriteLine(weko);
            weko.SetProperty("FirstName", "Weko");
            Console.WriteLine(weko);
        }
    }
}
