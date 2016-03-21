using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlugCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();

            calc.Operations = new List<IOperation> {
                new AddOperation(),
                new MulOperation(),
                new SubOperation()
            };

            var first = 5;
            var second = 3;

            foreach (var operation in calc.Operations)
            {
                Console.WriteLine($"{first} {second} {operation.Calculate(first, second)}");
            }
        }
    }
}
