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
        
        public static IReadOnlyCollection<string> WizardsByCreator(this Wizard wizard, string creator)
        {
            var wizards = wizard.Wizards.Value;
            var wizardNames = from w in wizards
                                              where w.Creator.Contains(creator)
                                              select w.Name;
            return wizardNames.ToList().AsReadOnly();
        }
        public static int YearOfWizardIntroduction(this Wizard wizard, string wizardName)
        {
            var wizards = wizard.Wizards.Value;
            var introductionYear = from w in wizards
                                                where w.Name.Contains(wizardName)
                                                select w.Year;
            return introductionYear.Min().Value;
        }
        public static IReadOnlyCollection<(string,int)> NameAndYearOfWizardFromMedium(this Wizard wizard, string medium)
        {
            var wizards = wizard.Wizards.Value;
            var tuple = from w in wizards
                where w.Medium.Contains(medium)
                select (w.Name, w.Year.Value);
            return tuple.ToList().AsReadOnly();
        }
        public static IReadOnlyCollection<string> WizardsNamesOrderedByCreator(this Wizard wizard)
        {
            var wizards = wizard.Wizards.Value;
            var allWizards = from w in wizards
                orderby w.Creator descending, w.Name
                select w.Name;
            return allWizards.ToList().AsReadOnly();
        }
    }
}
