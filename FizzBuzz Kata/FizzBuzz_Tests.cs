using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Kata.FizzBuzz_Kata
{
    public class FizzBuzz_Tests
    {
        [Fact]
        public void GetNumbers_ReturnsNumbers()
        {
            FizzBuzz fizzBuzz = new FizzBuzz();
            string expNumber = "1 2 Fizz 4 Buzz Fizz 7 8 Fizz Buzz 11 Fizz 13 14 FizzBuzz 16 17 Fizz 19 Buzz Fizz 22 23 Fizz Buzz 26 Fizz 28 29 FizzBuzz 31 32 Fizz 34 Buzz Fizz 37 38 Fizz Buzz 41 Fizz 43 44 FizzBuzz 46 47 Fizz 49 Buzz Fizz 52 53 Fizz Buzz 56 Fizz 58 59 FizzBuzz 61 62 Fizz 64 Buzz Fizz 67 68 Fizz Buzz 71 Fizz 73 74 FizzBuzz 76 77 Fizz 79 Buzz Fizz 82 83 Fizz Buzz 86 Fizz 88 89 FizzBuzz 91 92 Fizz 94 Buzz Fizz 97 98 Fizz Buzz";

            string actNumbers = fizzBuzz.GetNumbers();

            Assert.Equal(expNumber, actNumbers);
        }

        [Theory]
        [InlineData("1", 1)]
        [InlineData("98", 98)]
        [InlineData("Fizz", 3)]
        [InlineData("Buzz", 5)]
        [InlineData("FizzBuzz", 15)]
        public void GetNumber_GivenValidNumber_ReturnsNumber(string expNumber, int number)
        {
            FizzBuzz fizzBuzz = new FizzBuzz();

            string actNumbers = fizzBuzz.GetNumber(number);

            Assert.Equal(expNumber, actNumbers);
        }

        [Theory]
        [InlineData(null)]
        [InlineData(-1)]
        [InlineData(0)]
        [InlineData(101)]
        public void GetNumber_GivenInvalidNumber_ThrowsError(int number)
        {
            FizzBuzz fizzBuzz = new FizzBuzz();

            void act() => fizzBuzz.GetNumber(number);

            Assert.Throws<ArgumentException>(act);
        }
    }
}
