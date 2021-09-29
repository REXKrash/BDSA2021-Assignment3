using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace BDSA2020.Assignment03.Tests
{
    public class ExtensionsTests
    {
        [Fact]
        public void Flatten_givenTwoLists_correctCombinedList()
        {

            // Arrange
            var list1 = new List<int>() { 1, 2, 3 };
            var list2 = new List<int>() { 4, 5, 6 };

            var superList = new List<int>[] { list1, list2 };

            // Act
            var flatList = superList.Flatten();

            // Assert
            var expected = new List<int>() { 1, 2, 3, 4, 5, 6 };
            Assert.Equal(expected, flatList);
        }

        [Fact]
        public void SelectDivisible_givenNumberArray_correctOutput()
        {

            // Arrange
            var input = new int[] { 1, 2, 3, 42, 49, 56 };

            // Act
            var output = input.SelectDivisible();

            // Assert
            var expected = new int[] { 49, 56 };
            Assert.Equal(expected, output);
        }

        [Fact]
        public void GetLeapYears_givenArrayOfYears_correctLeapYears()
        {
            // Arrange
            var input = new int[] { -1700, -4, 0, 3, 4, 1600, 1700, 1800, 1900, 2000 };

            // Act
            var output = input.GetLeapYears();

            // Assert
            var expected = new int[] { -4, 0, 4, 1600, 2000 };
            Assert.Equal(expected, output);
        }

        [Fact]
        public void IsSecure_GivenTwoLinks_SecureAndNotSecure()
        {

            // Arrange and act
            bool isSecure1 = new Uri("https://google.com").IsSecure();
            bool isSecure2 = new Uri("http://google.com").IsSecure();

            // Assert
            Assert.Equal(true, isSecure1);
            Assert.Equal(false, isSecure2);
        }

        [Fact]
        public void WordCount_GivenWords_CorrectAmountOfWords()
        {

            // Arrange and act
            var input = "Hello my name is 12[]!#¤% &/()=? @£$€{[]}| ÆØÅ";
            int wordCount = input.WordCount();

            // Assert
            Assert.Equal(5, wordCount);
        }

        [Theory]
        [InlineData("Harry Potter")]
        [InlineData("Albus Dumbledore")]
        [InlineData("Severus Snape")]
        [InlineData("Sirius Black")]
        [InlineData("Voldemort")]
        [InlineData("Remus Lupin")]
        
        public void WizardsByCreator_given_Rowling_return_all_from_harry_potter(string name)
        {
            var wizard = Wizard.Wizards.Value.First();

            // Act
            var wizards = wizard.WizardsByCreator("Rowling");

            // Assert
            Assert.Contains(wizards, w => w == name);
        }
        
        [Fact]
        public void YearOfWizardIntroduction_returns_1977_given_Darth()
        {
            // Arrange
            var expectedYear = 1977;
            var wizard = Wizard.Wizards.Value.First();

            // Act
            var actualYear = wizard.YearOfWizardIntroduction("Darth");

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
            var wizard = Wizard.Wizards.Value.First();

            // Act
            var actualWizardsAndYear = wizard.NameAndYearOfWizardFromMedium("Harry Potter");
            
            // Assert
            Assert.Contains(actualWizardsAndYear, t => 
                t.Item1 == name &&
                t.Item2 == year
                );
        }
        [Fact]
        public void WizardsNamesOrderedByCreator_returns_correct_order()
        {
            var wizard = Wizard.Wizards.Value.First();

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

            var actual = wizard.WizardsNamesOrderedByCreator();
            Assert.Equal(expected,actual);
        }
    }
}
