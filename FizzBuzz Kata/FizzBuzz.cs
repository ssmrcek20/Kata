using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.FizzBuzz_Kata
{
    public class FizzBuzz
    {
        public string GetNumbers()
        {
            StringBuilder numbers = new StringBuilder();
            numbers.Append(CheckNumber(1));
            for (int i = 2; i <= 100; i++)
            {
                numbers.Append(' ');
                numbers.Append(CheckNumber(i));
            }
            return numbers.ToString();
        }

        public string GetNumber(int number)
        {
            CheckIfNumberIsValid(number);
            return CheckNumber(number);
        }

        private void CheckIfNumberIsValid(int number)
        {
            if (number > 100 || number < 1)
            {
                throw new ArgumentException("Number isn't in range of 1-100");
            }
        }

        private string CheckNumber(int i)
        {
            if (i % 3 == 0)
            {
                if (i % 5 == 0)
                {
                    return "FizzBuzz";
                }
                else
                {
                    return "Fizz";
                }
            }
            else if (i % 5 == 0)
            {
                return "Buzz";
            }
            else return i.ToString();
        }
    }
}
