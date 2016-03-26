using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamo
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic x = DynCreator.GetSomeObject(0.7);
            x.FirstName = "Weko";
            Console.WriteLine(x);

            dynamic y = DynCreator.GetSomeObject(0.3);
            y.Year = 1997;
            Console.WriteLine(y);

        }
    }


}
