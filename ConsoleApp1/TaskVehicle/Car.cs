using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskVehicle
{
    internal class Car : IVehicle 
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int ProduceYear { get; set; }
        public Car(string name, string model, string color, int produceyear) 
        {
            this.Name = name;
            this.Model = model;
            this.Color = color;
            this.ProduceYear = produceyear;
        }
        public void GetDetails()
        {
            Console.WriteLine($"{Name} {Model} {Color} {ProduceYear}");
        }

        public void Start()
        {
            Console.WriteLine("Car engine started");
        }

        public void Stop()
        {
            Console.WriteLine("Car engine stopped");
        }
    }
}
