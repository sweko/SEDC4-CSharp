using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LinqDemo.GetMaleAge());
            return;
            string word = Console.ReadLine();
            Console.WriteLine(StringUtil.IsPalindrome(word));

            int i = 7;

            Console.WriteLine(IntUtil.IsEven(i));
            Console.WriteLine(IntUtil.IsOdd(i));

            Console.WriteLine(IntUtil.Triple(i));

            int x = int.Parse(Console.ReadLine());
            //var formula = x.Triple().Increment().Square();
            //Console.WriteLine(formula);
            //var formulaOld = IntUtil.Square(IntUtil.Increment(IntUtil.Triple(x)));
            //Console.WriteLine(formulaOld);

            var formula = x.Triple()
                .IncrementBy(10)
                .Square()
                .IncrementBy(x.IncrementBy(7));

            Console.WriteLine(formula);
            var formulaOld = IntUtil.IncrementBy(
                IntUtil.Square(
                    IntUtil.IncrementBy(
                        IntUtil.Triple(x),10
                    )
                ),
                IntUtil.IncrementBy(x, 7));
            Console.WriteLine(formulaOld);

        }
    }
}
