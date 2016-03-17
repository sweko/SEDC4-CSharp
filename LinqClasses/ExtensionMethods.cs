﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqClasses
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

    }
}