using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter name: ");
            var name = Console.ReadLine();
            Console.WriteLine("Hello " + name);

            var x = 2 + 2;
            int y = (int)Math.Pow(x, 3.2);
            Console.WriteLine("y " + y);
            Console.ReadLine();

            //console.log("hello javascript");
            //Console.WriteLine("Hello C#");
            //Console.WriteLine("Hello from the other side");
            //Console.WriteLine("Hello I love you");
            //Console.WriteLine("Hello Hello");

            //Console.ReadLine();
        }
    }
}
