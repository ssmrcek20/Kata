using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.String_Sum_Kata
{
    public class StringSum
    {
        public int Sum(string num1, string num2)
        {
            num1 = ChechIfValid(num1);
            num2 = ChechIfValid(num2);

            return int.Parse(num1) + int.Parse(num2);
        }

        private string ChechIfValid(string num)
        {
            if (IsNull(num) || IsNegativ(num) || IsDecimal(num) || IsEmptyString(num))
            {
                return "0";
            }
            return num;
        }

        private bool IsEmptyString(string num)
        {
            return num.Contains(" ");
        }

        private bool IsNull(string num)
        {
            return string.IsNullOrEmpty(num);
        }

        private bool IsDecimal(string num)
        {
            return num.Contains(".");
        }

        private bool IsNegativ(string num)
        {
            return num.Contains("-");
        }
    }
}
