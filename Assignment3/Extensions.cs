using System;
using System.Collections.Generic;
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
        
        public static IReadOnlyCollection<string> WizardsByCreator(this Wizard wizard, string creator) => Wizard.Wizards.Value.Where(x => x.Creator.Contains(creator)).Select(x => x.Name).ToList().AsReadOnly();

        public static int YearOfWizardIntroduction(this Wizard wizard, string wizardName) => Wizard.Wizards.Value.Where(x => x.Name.Contains(wizardName)).Select(x => x.Year).Min().Value;

        public static IReadOnlyCollection<(string,int)> NameAndYearOfWizardFromMedium(this Wizard wizard, string medium) => Wizard.Wizards.Value.Where(x => x.Medium.Contains(medium)).Select(x => (x.Name, x.Year.Value)).ToList().AsReadOnly();
        
        public static IReadOnlyCollection<string> WizardsNamesOrderedByCreator(this Wizard wizard) => Wizard.Wizards.Value.OrderBy(x => x.Name).OrderByDescending(x => x.Creator).Select(x => x.Name).ToList().AsReadOnly();
    }
}
