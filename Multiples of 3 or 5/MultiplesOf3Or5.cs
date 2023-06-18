using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.Multiples_of_3_or_5
{
    public class MultiplesOf3Or5
    {
        public int GetValue(int number)
        {
            int sum = 0;
            for(int i = 1; i < number; i++)
            {
                sum += (i % 3 == 0 || i % 5 == 0) ? i : 0;
            }
            return sum;
        }
    }
}

