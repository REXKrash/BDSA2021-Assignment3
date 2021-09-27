using Xunit;

namespace BDSA2020.Assignment03.Tests
{
    public class WizardTests
    {
        [Fact]
        public void Wizards_contains_12_wizards()
        {
            var wizards = Wizard.Wizards.Value;

            Assert.Equal(12, wizards.Count);
        }

        [Theory]
        [InlineData("Darth Vader", "Star Wars", 1977, "George Lucas")]
        [InlineData("Sauron", "The Fellowship of the Ring", 1954, "J.R.R. Tolkien")]
        [InlineData("Harry Potter", "Harry Potter and the Philosopher's Stone", 1997, "J.K. Rowling")]
        [InlineData("Gandalf", "The Fellowship of the Ring", 1954, "J.R.R. Tolkien")]
        [InlineData("Merlin", "The Lost Years of Merlin", 1996, "T.A. Barron")]
        [InlineData("Yoda", "Star Wars", 1977, "George Lucas")]
        [InlineData("Albus Dumbledore", "Harry Potter and the Philosopher's Stone", 1997, "J.K. Rowling")]
        [InlineData("Severus Snape", "Harry Potter and the Philosopher's Stone", 1997, "J.K. Rowling")]
        [InlineData("Sirius Black", "Harry Potter and the Prisoner of Azkaban", 1999, "J.K. Rowling")]
        [InlineData("Raistlin Majere", "The Test of the twins", 1984, "Margaret Weis")]
        [InlineData("Voldemort", "Harry Potter and the Philosopher's Stone", 1997, "J.K. Rowling")]
        [InlineData("Remus Lupin", "Harry Potter and the Prisoner of Azkaban", 1999, "J.K. Rowling")]
        public void Spot_check_wizards(string name, string medium, int year, string creator)
        {
            var wizards = Wizard.Wizards.Value;

            Assert.Contains(wizards, w =>
                w.Name == name &&
                w.Medium == medium &&
                w.Year == year &&
                w.Creator == creator
            );
        }
    }
}

