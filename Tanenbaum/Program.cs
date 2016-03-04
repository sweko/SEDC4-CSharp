using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tanenbaum
{
    class Program
    {
        static void Main(string[] args)
        {
            // DO NOT TRY TO UNDERSTAND THIS CODE
            // THE TEACHER IS JUST SHOWING OFF
            int n = int.Parse(Console.ReadLine());

            Enumerable.Range(1, n)
            .Select(i => "".PadLeft(n - i) + new string('*', i * 2 - 1))
            .ToList().ForEach(Console.WriteLine);
            new List<int> { 0, 0, 0 }
            .ForEach(_ => Console.WriteLine(string.Concat("".PadLeft(n-1), "*")));
        }
    }
}
