using Kata.Multiples_of_3_or_5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Kata.Who_likes_it
{
    public class WhoLikesIt_Tests
    {
        [Theory]
        [InlineData("no one likes this", new string[0])]
        [InlineData("Peter likes this", new string[] { "Peter" } )]
        [InlineData("Jacob and Alex like this", new string[] { "Jacob", "Alex" })]
        [InlineData("Max, John and Mark like this", new string[] { "Max", "John", "Mark" })]
        [InlineData("Alex, Jacob and 2 others like this", new string[] { "Alex", "Jacob", "Mark", "Max" })]
        public void Test(string expValue, string[] names)
        {
            WhoLikesIt whoLikesIt = new WhoLikesIt();

            string actValue = whoLikesIt.GetDisplayText(names);

            Assert.Equal(expValue, actValue);
        }
    }
}
