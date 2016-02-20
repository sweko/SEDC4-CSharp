using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var weko = new Person("Wekoslav","Stefanovski", 0x26);

            var jasmina= new Person("Jasmina", "Kostova");
            jasmina.Age = 3;

            Console.WriteLine($"Person is {weko.FullName} and is {weko.Age} years old");
            Console.WriteLine($"Person is {jasmina.FullName} and is {jasmina.Age} years old");

            jasmina.Age += 1;

            Console.WriteLine($"Person is {jasmina.FullName} and is {jasmina.Age} years old");

            //weko.FullName = "Stavre Jovevski";

            //jasmina.Age = -19;



        }
    }
}

