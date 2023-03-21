using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    public class BubbleSorting
    {
        public static int[] Sort(int[] array)
        {
            int length = array.Length;

            int arr = array[0];

            for (int i = 0; i < length; i++)
            {
                for (int j = i + 1; j < length; j++)
                {
                    if (array[i] > array[j])
                    {
                        arr = array[i];

                        array[i] = array[j];

                        array[j] = arr;
                    }
                }
            }

            return array;
        }
    }
}
