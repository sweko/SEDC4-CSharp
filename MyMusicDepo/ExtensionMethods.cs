using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMusicDepo
{
    public static class ExtensionMethods
    {
        public static IEnumerable<T> Filter<T>(this IEnumerable<T> items, Func<T, bool> filter)
        {
            var result = new Queue<T>();
            foreach (var item in items)
            {
                if (filter(item))
                {
                    result.Enqueue(item);
                }
            }
            return result;
        }

        public static void PrintItems<T>(this IEnumerable<T> items)
        {
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("---------------------------");
        }

        public static IEnumerable<TOut> Map<TIn, TOut>(this IEnumerable<TIn> source, Func<TIn, TOut> mapper)
        {
            var result = new List<TOut>();
            foreach (var item in source)
            {
                result.Add(mapper(item));
            }
            return result;
        }

    }
}
