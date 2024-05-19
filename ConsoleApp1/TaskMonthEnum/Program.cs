namespace TaskMonthEnum
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Enter number between 1 and 12: ");
            int month = Convert.ToInt32(Console.ReadLine());
            switch (month)
            {
                case (int)Month.January:
                    Console.WriteLine("January, Month of Winter"); break;
                case (int)Month.February:
                    Console.WriteLine("February, Month of Winter"); break;
                case (int)Month.March:
                    Console.WriteLine("March, Month of Spring"); break;
                case (int)Month.April:
                    Console.WriteLine("April, Month of Spring"); break;
                case (int)Month.May:
                    Console.WriteLine("May, Month of Spring"); break;
                case (int)Month.June:
                    Console.WriteLine("June, Month of June"); break;
                case (int)Month.July:
                    Console.WriteLine("July, Month of June"); break;
                case (int)Month.August:
                    Console.WriteLine("August, Month of June"); break;
                case (int)Month.September:
                    Console.WriteLine("September, Month of Autumn"); break;
                case (int)Month.October:
                    Console.WriteLine("October, Month of Autumn"); break;
                case (int)Month.November:
                    Console.WriteLine("November, Month of Autumn"); break;
                case (int)Month.December: 
                    Console.WriteLine("December, Month of Winter"); break;
                default:
                    Console.WriteLine("Error: Enter correct number");
                    break;
            }
        }
    }
}
