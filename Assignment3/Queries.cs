using System.Collections.Generic;
using System.Linq;

namespace BDSA2020.Assignment03
{
    public class Queries
    {
        public static IReadOnlyCollection<string> WizardsByCreator(string creator)
        {
            var wizards = Wizard.Wizards.Value;
            var wizardNames = from wizard in wizards
                                              where wizard.Creator.Contains(creator)
                                              select wizard.Name;
            return wizardNames.ToList().AsReadOnly();
        }
        public static int YearOfWizardIntroduction(string wizard)
        {
            var wizards = Wizard.Wizards.Value;
            var introductionYear = from w in wizards
                                                where w.Name.Contains(wizard)
                                                select w.Year;
            return introductionYear.Min().Value;
        }
        public static IReadOnlyCollection<(string,int)> NameAndYearOfWizardFromMedium(string medium)
        {
            var wizards = Wizard.Wizards.Value;
            var tuple = from w in wizards
                where w.Medium.Contains(medium)
                select (w.Name, w.Year.Value);
            return tuple.ToList().AsReadOnly();
        }
        public static IReadOnlyCollection<string> WizardsNamesOrderedByCreator()
        {
            var wizards = Wizard.Wizards.Value;
            var allWizards = from w in wizards
                orderby w.Creator descending, w.Name
                select w.Name;
            return allWizards.ToList().AsReadOnly();
        }
        
    }
}
