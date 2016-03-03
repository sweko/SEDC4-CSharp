using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Enter #{i + 1}: ");
                string input = Console.ReadLine();
                int number = int.Parse(input);
                numbers[i] = number;
            }

            int min = int.MaxValue;
            int max = int.MinValue;
            int sum = 0;

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    var number = numbers[i];
            //    Console.WriteLine(number);
            //}

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            //int max = int.MinValue;
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.Write($"Enter #{i+1}: ");
            //    string input = Console.ReadLine();
            //    int number = int.Parse(input);
            //    if (number > max)
            //    {
            //        max = number;
            //    }
            //}

            //Console.WriteLine($"The maximum number is {max}");

        }
    }
}
