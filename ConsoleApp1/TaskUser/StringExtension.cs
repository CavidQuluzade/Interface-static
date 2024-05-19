using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskUser
{
    internal static class StringExtension
    {
        public static bool PinCheck(this string pin)
        {
            if (pin.Length < 7 ) return false;
            foreach (char c in pin)
            {
                if (!char.IsUpper(c) && !char.IsDigit(c)) 
                {
                    return false;
                }
            }
            return true;
            
        }
    }
}
