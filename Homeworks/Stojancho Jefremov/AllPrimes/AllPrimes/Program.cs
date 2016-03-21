using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllPrimes
{
    class Program
    {
        static IEnumerable<int> GetAllPrimeNumbers()
        {
            int number = 1;
            while (true)
            {
                ++number;
                if (!IsPrime(number))
                {
                    continue;
                };
                yield return number;
            }
        }

        public static bool IsPrime(int number)
        {
            int boundary = (int)Math.Ceiling(Math.Sqrt(number));

            if (number == 1) return false;
            if (number == 2) return true;

            for (int i = 2; i <= boundary; i++)  {
                if (number % i == 0)  return false;
            }

            return true;        
        }
        static void Main(string[] args)
        {
            GetAllPrimeNumbers().Take(20).ToList().ForEach(Console.WriteLine);
        }
    }
}
