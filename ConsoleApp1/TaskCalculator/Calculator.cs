using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Calculator :ICalculate1
    {
        public double Number1 {  get; set; }
        public double Number2 { get; set; }
        public Calculator(double number1, double number2) 
        {
            this.Number1 = number1;
            this.Number2 = number2;
        }

        public  double Sum()
        {
            return Number1 + Number2;
        }

        public double Multiple()
        {
            return Number1 * Number2;
        }

        public double Substract()
        {
            return Number1 - Number2;
        }

        public double Derive()
        {
            if (Number2 == 0)
            {
                Console.WriteLine("Derived by zero");
            }
            return Number1 / Number2;
        }
    }

}
