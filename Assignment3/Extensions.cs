using System;
using System.Collections.Generic;
using System.Linq;

namespace BDSA2020.Assignment03
{
    public static class Extensions
    {
        public static IEnumerable<int> Flatten(this IEnumerable<int>[] items) => items.SelectMany(x => x);
    
        public static int[] SelectDivisible(this int[] numbers) => numbers.Where(x => x > 42 && x % 7 == 0).ToArray<int>();
    }
}
