﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskIntegerPrimeExtension
{
    internal static class MathUtils
    {
        public static bool PrimeCheck(this int n)
        {
            for (int i = 2; i < n/2; i++)
            {
                if (n % i != 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
