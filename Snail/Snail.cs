using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.Snail
{
    public class Snail
    {
        public int[] GetArray(int[][] array)
        {
            int iteration2 = 0;
            int iteration1 = 0;
            List<int> list = new List<int>();

            if(array.Length % 2 == 0)
            {
                for(int i = 0; i < array[0].Length/2-1; i++)
                {
                    list.AddRange(Forward(iteration1, iteration2, array[i]));
                    list.AddRange(Down(iteration1, iteration2, array));
                    list.AddRange(Backward(iteration1, iteration2, array[array[0].Length - i - 1]));
                    list.AddRange(Up(iteration1, iteration2, array));
                    iteration2 += 2;
                    iteration1 += 1;
                }
                list.AddRange(Forward(iteration1, iteration2, array[array[0].Length/2-1]));
                list.AddRange(Down(iteration1, iteration2, array));
                list.AddRange(Backward(iteration1, iteration2, array[array[0].Length/2]));

                return list.ToArray();
            }
            else
            {
                for (int i = 0; i < array[0].Length/2; i++)
                {
                    list.AddRange(Forward(iteration1, iteration2, array[i]));
                    list.AddRange(Down(iteration1, iteration2, array));
                    list.AddRange(Backward(iteration1, iteration2, array[array[0].Length - i - 1]));
                    list.AddRange(Up(iteration1, iteration2, array));
                    iteration2 += 2;
                    iteration1 += 1;
                }
                list.AddRange(Forward(iteration1, iteration2, array[array[0].Length/2]));

                return list.ToArray();
            }
        }

        private int[] Up(int iteration1, int iteration2, int[][] array)
        {
            int[] newArray = new int[array[0].Length - iteration2 - 2];
            int index = 0;
            for (int i = array[0].Length -2 - iteration1; i > iteration1; i--)
            {
                newArray[index] = array[i][iteration1];
                index++;
            }
            return newArray;
        }
        private int[] Backward(int iteration1, int iteration2, int[] array)
        {
            int[] newArray = new int[array.Length - iteration2 - 1];
            int index = 0;
            for (int i = array.Length - iteration1 - 2; i >= iteration1; i--)
            {
                newArray[index] = array[i];
                index++;
            }
            return newArray;
        }

        private int[] Down(int iteration1, int iteration2, int[][] array)
        {
            int[] newArray = new int[array[0].Length - iteration2 - 1];
            for (int i = 1 + iteration1; i < array[0].Length - iteration2 + iteration1; i++)
            {
                newArray[i-1-iteration1] = array[i][array[0].Length - iteration1 - 1];
            }
            return newArray;
        }

        private int[] Forward(int iteration1, int iteration2, int[] array)
        {
            int[] newArray = new int[array.Length - iteration2];
            for(int i=0 + iteration1; i < array.Length - iteration2 + iteration1; i++)
            {
                newArray[i-iteration1] = array[i];
            }
            return newArray;
        }
    }
}
