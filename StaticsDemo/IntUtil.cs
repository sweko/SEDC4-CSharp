using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticsDemo
{
    public static class IntUtil
    {
        public static bool IsEven(this int number)
        {
            return number % 2 == 0;
        }

        public static bool IsOdd(this int number)
        {
            return number % 2 != 0;
        }

        public static int Triple(this int number)
        {
            return 3 * number;
        }

        public static int Square(this int number)
        {
            return number * number;
        }

        public static int Cube(this int number)
        {
            return number * number * number;
        }

        public static int Increment(this int number)
        {
            return number+1;
        }

        public static int IncrementBy(this int number, int increment)
        {
            return number + increment;
        }


    }
}
