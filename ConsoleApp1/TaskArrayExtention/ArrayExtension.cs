using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskArrayExtension
{
    internal static class ArrayExtension
    {
        public static int ArrayAverage(this int[] array)
        {
            int avg = 0;
            for (int i = 0; i < array.Length; i++)
            {
                avg += array[i];
            }
            return avg/array.Length;
        }
    }
}
