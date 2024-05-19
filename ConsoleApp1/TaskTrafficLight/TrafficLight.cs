using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskTrafficLight
{
    public class TrafficLight
    {
        public enum Color
        {
            Red,
            Yellow,
            Green
        }
        private Color currentColor;
        public TrafficLight()
        {         
            currentColor = Color.Red;
        }
        public void ChangeNextColor()
        {
            switch (currentColor)
            {
                case Color.Red:
                    currentColor = Color.Green;
                    break;
                case Color.Yellow:
                    currentColor = Color.Red;
                    break;
                case Color.Green:
                    currentColor = Color.Yellow;
                    break;
            }
            Console.WriteLine($"Current color changed to: {currentColor}");
        }
        public void ShowCurrentColor()
        {
            Console.WriteLine($"Current color: {currentColor}");
        }
    }
}
