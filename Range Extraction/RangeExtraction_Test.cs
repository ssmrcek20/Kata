using Kata.Human_Readable_Time;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Kata.RangeExtraction
{
    public class RangeExtraction_Tests
    {
        [Fact]
        public void Test()
        {
            RangeExtraction rangeExtraction = new RangeExtraction();

            Assert.Equal("1,2", rangeExtraction.Extract(new[] { 1, 2 }));
            Assert.Equal("1-3", rangeExtraction.Extract(new[] { 1, 2, 3 }));
            Assert.Equal("-6,-3-1,3-5,7-11,14,15,17-20", rangeExtraction.Extract(new[] { -6, -3, -2, -1, 0, 1, 3, 4, 5, 7, 8, 9, 10, 11, 14, 15, 17, 18, 19, 20 }));
            Assert.Equal( "-3--1,2,10,15,16,18-20", rangeExtraction.Extract(new[] { -3, -2, -1, 2, 10, 15, 16, 18, 19, 20 }));
            Assert.Equal("-50--47,-45,-44,-42,-40", rangeExtraction.Extract(new[] { -50, -49, -48, -47, -45, -44, -42, -40 }));
            Assert.Equal("-50--47,-50", rangeExtraction.Extract(new[] { -50, -49, -48, -47, -47, -50 }));
            Assert.Equal("-50--47,-50,-70", rangeExtraction.Extract(new[] { -50, -49, -48, -47, -47, -50, -70 }));
        }
    }
}
