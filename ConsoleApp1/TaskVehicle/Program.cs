namespace TaskVehicle
{
    internal class Program
    {
        static void Main()
        {
            Car car = new("Mercedes-Benz", "S600", "Black", 1991);
            Bus bus = new("BMC", "---", "Red", 2020);
            Motorcycle motorcycle = new("BMW", "---", "White", 2016);
            car.GetDetails();
            car.Start();
            car.Stop();
            bus.GetDetails();
            bus.Start();
            bus.Stop();
            motorcycle.GetDetails();
            motorcycle.Start();
            motorcycle.Stop();
        }
    }
}
