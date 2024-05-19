using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskTempeture
{
    internal static class ConvertTemperature
    {
        
        

        public static double CelsiusToFahrenheit(double temperature)
        {
            return (temperature * 1.8) + 32;
        }
        public static double FahrenheitToCelsius(double temperature) 
        {
            return 5 / 9 * (temperature - 32);
        }
    }
}
