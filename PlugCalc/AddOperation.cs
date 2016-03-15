using System;

namespace PlugCalc
{
    internal class AddOperation : IOperation
    {
        public string Name { get; set; }

        public int Calculate(int first, int second)
        {
            return first + second;
        }
    }
}