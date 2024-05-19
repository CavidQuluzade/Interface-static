using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatetimeExtension
{
    internal static class DatetimeExtention
    {
       
        public static int AgeCheck(this DateTime birthdate)
        {
          
            DateTime todaysdate = DateTime.Now;
            if((birthdate.Month- todaysdate.Month < 0) || (birthdate.Month == todaysdate.Month && birthdate.Day - todaysdate.Day<0)) 
            {
                return todaysdate.Year - birthdate.Year - 1;
            }
            return
                todaysdate.Year - birthdate.Year;
        }
    }
}
