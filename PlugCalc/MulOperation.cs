using System;

namespace PlugCalc
{
    internal class MulOperation : IOperation
    {
        public int Calculate(int first, int second)
        {
            return first * second;
        }
    }
}