using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var chars = new List<char>();
            Console.Write($"Enter your full name: ");
            string input = Console.ReadLine();
            
            for (int i = 0; i < input.Length; i++)
            {
                chars.Add(input[i]);
            }

            var x = chars[2];

            foreach (var item in chars)
            {
                Console.WriteLine(item);
            }

            
        }

        //static void Main(string[] args)
        //{
        //    Console.Write($"Enter number: ");
        //    string input = Console.ReadLine();
        //    int number = int.Parse(input);

        //    var digits = new List<int>();

        //    while (number != 0)
        //    {
        //        var digit = number % 10;
        //        digits.Add(digit);
        //        number /= 10;
        //    }

        //    digits.Reverse();

        //    int sum = 0;
        //    foreach (var digit in digits)
        //    {
        //        Console.Write($"{digit}-");
        //        sum += digit;
        //    }
        //    Console.WriteLine();

        //    Console.WriteLine($"Sum of digits is {sum}");
        //}
    }
}
