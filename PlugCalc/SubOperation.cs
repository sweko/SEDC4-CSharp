using System;

namespace PlugCalc
{
    internal class SubOperation : IOperation
    {
        public int Calculate(int first, int second)
        {
            return first - second;
        }
    }
}