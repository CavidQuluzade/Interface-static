using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskStringReverseExtension
{
    internal static class StringReverseExtension
    {
        public static string ReverseString(this string str)
        {
            return new string(str.Reverse().ToArray());
        }
    }
}
