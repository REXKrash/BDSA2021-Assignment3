using System;
using System.Collections.Generic;
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
    }
}
