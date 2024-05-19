using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskStringCapitalizeExtension
{
    internal static class StringCapitalizeExtension
    {
        public static string CapitalizeForFirstLetter(this string str)
        {
            return char.ToUpper(str[0]) + str.Substring(1);
        }
        public static string CapitalizeAll(this string str)
        {
            return new string(str.ToUpper().ToArray());
        }
    }
}
