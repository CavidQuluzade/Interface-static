using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskStringPolindromExtention
{
    public static class StringPolindromExtension
    {
        public static bool PolindromCheck(this string str)
        {
            int length = str.Length;
            for (int c = 0; c < str.Length; c++)
            {
                if (str[c] != str[length-1-c])
                {
                    return false;
                }  
            }
            return true;
        } 
    }
}
