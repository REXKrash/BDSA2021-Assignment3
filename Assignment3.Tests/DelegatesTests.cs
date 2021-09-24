using System;
using System.IO;
using System.Linq;
using Xunit;

namespace BDSA2020.Assignment03.Tests
{
    public class DelegatesTests
    {
        [Fact]
        public void ReverseString_givenAbcdefgh_returnsHgfedcba()
        {
            Action<string> reverse = str => Array.ForEach<char>(str.Reverse().ToArray(), (c => Console.Write(c)));

            var writer = new StringWriter();
            Console.SetOut(writer);

            reverse("abcdefgh");
            var output = writer.GetStringBuilder().ToString().Trim();

            Assert.Equal("hgfedcba", output);
        }

        [Fact]
        public void GivenTwoDecimals_returnProduct()
        {
            decimal findProduct(decimal x, decimal y) => x * y;

            Assert.Equal(20m, findProduct(2m, 10m));
        }

        [Fact]
        public void GivenNumberAndString_checkIfEqual()
        {

            bool numericallyEqual(string str, int num) => num == int.Parse(str);

            var str = "4311";
            var num = 4311;

            Assert.Equal(true, numericallyEqual(str, num));
        }
    }
}
