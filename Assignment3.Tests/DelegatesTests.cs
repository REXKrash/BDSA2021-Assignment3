using System;
using System.IO;
using System.Linq;
using Xunit;

namespace BDSA2020.Assignment03.Tests
{
    public class DelegatesTests
    {
        [Fact]
        public void String_reverse_given_abc_returns_cba()
        {
            Action<string> reverse = str => Console.WriteLine(str.Reverse());

            var writer = new StringWriter();
            Console.SetOut(writer);

            reverse("abcdefgh");
            var output = writer.GetStringBuilder().ToString().Trim();

            Assert.Equal("gfedcba", output);
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
