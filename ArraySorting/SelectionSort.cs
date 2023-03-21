using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
{
    public class SelectionSorting
    {
        public static void Change(ref int e1, ref int e2)
        {
            var temp = e1;
            e1 = e2;
            e2 = temp;
        }

        public static int[] SelectionSort(int[] array)
        {
            for (var i = 0; i < array.Length / 2; i++)
            {
                var selector = false;

                for (var j = i; j < array.Length - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        Change(ref array[j], ref array[j + 1]);
                        selector = true;
                    }
                }

                for (var j = array.Length - 2 - i; j > i; j--)
                {
                    if (array[j - 1] > array[j])
                    {
                        Change(ref array[j - 1], ref array[j]);
                        selector = true;
                    }
                }

                if (!selector)
                {
                    break;
                }
            }
            return array;
        }
    }
}




