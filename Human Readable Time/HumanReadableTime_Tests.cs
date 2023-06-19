using Kata.Multiples_of_3_or_5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Kata.Human_Readable_Time
{
    public class HumanReadableTime_Tests
    {
        [Theory]
        [InlineData("00:00:00", 0)]
        [InlineData("00:00:01", 1)]
        [InlineData("00:00:10", 10)]
        [InlineData("00:01:00", 60)]
        [InlineData("00:01:01", 61)]
        [InlineData("00:01:10", 70)]
        [InlineData("00:10:00", 600)]
        [InlineData("00:10:01", 601)]
        [InlineData("00:10:10", 610)]
        [InlineData("01:00:00", 3600)]
        [InlineData("01:00:01", 3601)]
        [InlineData("01:00:10", 3610)]
        [InlineData("01:01:00", 3660)]
        [InlineData("01:01:01", 3661)]
        [InlineData("01:01:10", 3670)]
        [InlineData("01:10:00", 4200)]
        [InlineData("01:10:01", 4201)]
        [InlineData("01:10:10", 4210)]
        [InlineData("10:00:00", 36000)]
        [InlineData("10:00:01", 36001)]
        [InlineData("10:00:10", 36010)]
        [InlineData("10:01:00", 36060)]
        [InlineData("10:01:01", 36061)]
        [InlineData("10:01:10", 36070)]
        [InlineData("10:10:00", 36600)]
        [InlineData("10:10:01", 36601)]
        [InlineData("10:10:10", 36610)]
        [InlineData("23:59:59", 86399)]
        [InlineData("99:59:59", 359999)]
        public void Test(string expValue, int seconds)
        {
            HumanReadableTime humanReadableTime = new HumanReadableTime();

            string actValue = humanReadableTime.GetRedableTime(seconds);

            Assert.Equal(expValue, actValue);
        }
    }
}
