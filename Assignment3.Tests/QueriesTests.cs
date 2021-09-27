using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace BDSA2020.Assignment03.Tests
{
    public class QueriesTests
    {
        [Theory]
        [InlineData("Harry Potter")]
        [InlineData("Albus Dumbledore")]
        [InlineData("Severus Snape")]
        [InlineData("Sirius Black")]
        [InlineData("Voldemort")]
        [InlineData("Remus Lupin")]
        
        public void WizardsByCreator_given_Rowling_return_all_from_harry_potter(string name)
        {
            // Act
            var wizards = Queries.WizardsByCreator("Rowling");

            // Assert
            Assert.Contains(wizards, w => w == name);
        }
        
        [Fact]
        public void YearOfWizardIntroduction_returns_1977_given_Darth()
        {
            // Arrange
            var expectedYear = 1977;

            // Act
            var actualYear = Queries.YearOfWizardIntroduction("Darth");

            // Assert
            Assert.Equal(expectedYear, actualYear);
        }
        
        [Theory]
        [InlineData("Harry Potter",1997)]
        [InlineData("Albus Dumbledore",1997)]
        [InlineData("Severus Snape",1997)]
        [InlineData("Sirius Black",1999)]
        [InlineData("Voldemort",1997)]
        [InlineData("Remus Lupin",1999)]
        public void NameAndYearOfWizardFromMedium_returns_all_wizards_from_The_Harry_Potter_books(string name, int year)
        {
            // Act
            var actualWizardsAndYear = Queries.NameAndYearOfWizardFromMedium("Harry Potter");
            
            // Assert
            Assert.Contains(actualWizardsAndYear, t => 
                t.Item1 == name &&
                t.Item2 == year
                );
        }
        [Fact]
        public void WizardsNamesOrderedByCreator_returns_correct_order()
        {
            var expected =  new List<string>();
            expected.AddRange(new []{
                "Merlin",
                
                "Raistlin Majere",
                
                "Gandalf",
                "Sauron",
                
                "Albus Dumbledore",
                "Harry Potter",
                "Remus Lupin",
                "Severus Snape",
                "Sirius Black",
                "Voldemort",
                
                "Darth Vader",
                "Yoda"
            });

            var actual = Queries.WizardsNamesOrderedByCreator();
            Assert.Equal(expected,actual);
        }
    }
}
