using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    public class QuickSorting
    {
        static void Swap(ref int x, ref int y)
        {
            var t = x;
            x = y;
            y = t;
        }

        public static int[] ArraySorting(int[] array)
        {
            return QuickSort(array, 0, array.Length - 1);
        }

        static int Section(int[] array, int minI, int maxI)
        {
            var pin = minI - 1;
            for (var i = minI; i < maxI; i++)
            {
                if (array[i] < array[maxI])
                {
                    pin++;
                    Swap(ref array[pin], ref array[i]);
                }
            }

            pin++;
            Swap(ref array[pin], ref array[maxI]);
            return pin;
        }

        static int[] QuickSort(int[] array, int minI, int maxI)
        {
            if (minI >= maxI)
            {
                return array;
            }

            var pinIndex = Section(array, minI, maxI);
            QuickSort(array, minI, pinIndex - 1);
            QuickSort(array, pinIndex + 1, maxI);

            return array;
        }

    }
}


