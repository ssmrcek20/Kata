using Kata.Human_Readable_Time;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Kata.Snail
{
    public class Snail_test
    {
        [Fact]
        public void Test3()
        {
            Snail snail = new Snail();
            int[] expArray = new[] { 1, 2, 3, 6, 9, 8, 7, 4, 5 };
            int[][] array =
            {
                new []{1, 2, 3},
                new []{4, 5, 6},
                new []{7, 8, 9}
            };

            int[] actArray = snail.GetArray(array);

            Assert.Equal(expArray, actArray);
        }
        [Fact]
        public void Test4()
        {
            Snail snail = new Snail();
            int[] expArray = new[] { 1, 2, 3, 1, 4, 7, 7, 9, 8, 7, 7, 4, 5, 6, 9, 8 };
            int[][] array =
            {
                new []{1, 2, 3, 1},
                new []{4, 5, 6, 4},
                new []{7, 8, 9, 7},
                new []{7, 8, 9, 7}
            };

            int[] actArray = snail.GetArray(array);

            Assert.Equal(expArray, actArray);
        }
    }
}
