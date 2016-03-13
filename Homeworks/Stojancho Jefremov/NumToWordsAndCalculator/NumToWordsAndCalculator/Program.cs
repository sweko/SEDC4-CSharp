using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumToWordsAndCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter number: ");
                var number = ulong.Parse(Console.ReadLine());
                Console.WriteLine(Converter.ToWords(number, Language.Macedonian));
            }
            //Console.ReadLine();
        }
    }
}
