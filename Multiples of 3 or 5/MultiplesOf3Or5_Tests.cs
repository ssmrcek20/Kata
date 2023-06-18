using Kata.String_Sum_Kata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Kata.Multiples_of_3_or_5
{
    public class MultiplesOf3Or5_Tests
    {
        [Theory]
        [InlineData(0, -10)]
        [InlineData(23, 10)]
        public void Test(int expValue, int number)
        {
            MultiplesOf3Or5 multiplesOf3Or5 = new MultiplesOf3Or5();

            int actValue = multiplesOf3Or5.GetValue(number);

            Assert.Equal(expValue, actValue);
        }
    }
}
