namespace TaskStringCapitalizeExtension
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "saLam";
            Console.WriteLine(name.CapitalizeForFirstLetter());
            Console.WriteLine(name.CapitalizeAll());
        }
    }
}
