using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            // DO NOT TRY TO UNDERSTAND THIS CODE
            // THE TEACHER IS JUST SHOWING OFF
            Dictionary<Tuple<bool, bool>, Func<int, string>> dict = new Dictionary<Tuple<bool, bool>, Func<int, string>>
            {
                { Tuple.Create(false, false), i => i.ToString()},
                { Tuple.Create(true, false), _ => "Fizz"},
                { Tuple.Create(false, true), _ => "Buzz"},
                { Tuple.Create(true, true), _ => "FizzBuzz"}
            };
            Enumerable.Range(1, 100).ToList().ForEach(i => Console.WriteLine(dict[Tuple.Create(i % 3 == 0, i % 5 == 0)](i)));
        }
    }
}
