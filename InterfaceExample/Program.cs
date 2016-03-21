using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var weko1 = new Person { ID = 1, FirstName = "Wekoslav", LastName = "Stefanovski" };
            var weko2 = new Person { ID = 2, FirstName = "Wekoslav", LastName = "Stefanovski" };

            Console.WriteLine(weko1.Equals(weko2));
        }
    }
}
