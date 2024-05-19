namespace ConsoleApp1
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Enter first number: ");
            double number1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter second number: ");
            double number2 = Convert.ToDouble(Console.ReadLine());
            Calculator calculator = new Calculator(number1, number2);
            Console.WriteLine("Select operatopr: '+', '-', '*', '/'");
            char Operate = Convert.ToChar(Console.ReadLine());
            switch(Operate)
            {
                case '+':
                    Console.WriteLine(calculator.Sum()); break;
                case '-':
                    Console.WriteLine(calculator.Substract()); break;
                case '*':
                    Console.WriteLine(calculator.Multiple()); break;
                case '/':
                    Console.WriteLine(calculator.Derive()); break;
                default:
                    Console.WriteLine("Choose correct operator"); break;
            }
            
            
        }
    }
}
