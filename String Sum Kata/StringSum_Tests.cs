using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Kata.String_Sum_Kata
{
    public class StringSum_Tests
    {
        [Theory]
        [InlineData("", "1")]
        [InlineData(null, "1")]
        [InlineData(" ", "1")]
        [InlineData("-1", "1")]
        [InlineData("0", "1")]
        [InlineData("1.1", "1")]
        public void Sum_GivenInvalidNumber1_ExpectOtherNumber(string num1, string num2)
        {
            StringSum stringSum = new StringSum();

            int sum = stringSum.Sum(num1, num2);

            Assert.Equal(1, sum);
        }

        [Theory]
        [InlineData("1", "")]
        [InlineData("1", null)]
        [InlineData("1", " ")]
        [InlineData("1", "-1")]
        [InlineData("1", "0")]
        [InlineData("1", "1.1")]
        public void Sum_GivenInvalidNumber2_ExpectOtherNumber(string num1, string num2)
        {
            StringSum stringSum = new StringSum();

            int sum = stringSum.Sum(num1, num2);

            Assert.Equal(1, sum);
        }

        [Theory]
        [InlineData("1", "1", 2)]
        [InlineData("100", "200", 300)]
        [InlineData("3", "13", 16)]
        public void Sum_GivenValidNumber_ExpectSum(string num1, string num2, int expSum)
        {
            StringSum stringSum = new StringSum();

            int sum = stringSum.Sum(num1, num2);

            Assert.Equal(expSum, sum);
        }
    }
}
