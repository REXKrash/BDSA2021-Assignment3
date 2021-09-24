using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;

namespace BDSA2020.Assignment03
{
    public static class Extensions
    {
        public static IEnumerable<int> Flatten(this IEnumerable<int>[] items) => items.SelectMany(x => x);

        public static int[] SelectDivisible(this int[] numbers) => numbers.Where(x => x > 42 && x % 7 == 0).ToArray<int>();

        public static int[] GetLeapYears(this int[] years) => years.Where(y => y % 100 == 0 ? y % 400 == 0 : y % 4 == 0).ToArray<int>();

        public static bool IsSecure(this Uri uri) => uri.Scheme == Uri.UriSchemeHttps;

        public static int WordCount(this string str) => Regex.Split(str, @"\P{L}+").Length;
    }
}
