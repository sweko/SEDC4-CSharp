using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter #1: ");
            string input = Console.ReadLine();
            int first = Convert.ToInt32(input);

            Console.Write("Enter #2: ");
            input = Console.ReadLine();
            int second = Convert.ToInt32(input);

            if (first > second)
            {
                Console.WriteLine($"{first} is bigger than {second}");
            }
            else
            {
                Console.WriteLine($"{first} is NOT bigger than {second}");
            }

            //if (args.Length == 0)
            //{
            //    Console.WriteLine("No parameters");
            //    return;
            //}

            //int integer = 1;
            //string name = "Wekoslav";
            //int[] array = { 1, 2, 3, 4 };
            //object obj = new { };
            //bool logic = integer == 1;

            //if (logic)
            //{
            //}
        }
    }
}
