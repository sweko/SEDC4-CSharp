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
            Console.OutputEncoding = Encoding.UTF8;
            while (true)
            {
                Console.Write("Enter number: ");
                var number = ulong.Parse(Console.ReadLine());
                Console.WriteLine(Converter.ToWords(number, Language.English));
                Console.WriteLine(Converter.ToWords(number, Language.Macedonian));
            }
            //Console.ReadLine();
        }
    }
}
