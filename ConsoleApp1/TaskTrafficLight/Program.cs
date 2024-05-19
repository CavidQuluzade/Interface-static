namespace TaskTrafficLight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TrafficLight trafficLight = new TrafficLight();
            trafficLight.ShowCurrentColor();
            trafficLight.ChangeNextColor();
            trafficLight.ChangeNextColor();
            trafficLight.ChangeNextColor();
        }
    }
}
