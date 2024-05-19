namespace DatetimeExtension
{
    internal class Program
    {
        static void Main()
        {
            var birtdate = new DateTime(2003, 10, 05);
            Console.WriteLine(birtdate.AgeCheck());
            
        }
    }
}
