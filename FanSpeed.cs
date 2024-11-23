using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class FanSpeed
    {
        static void Main(string[] args)
        {
            Fan fan1 = new Fan
            {
                Speed = Fan.FAST,
                Radius = 10,
                Color = "yellow",
                On= true

            };
            Fan fan2 = new Fan
            {
                Speed = Fan.MEDIUM,
                Radius = 5,
                Color = "blue",
                On = false

            };
            Console.WriteLine(fan1);
            Console.WriteLine(fan2);
        }
    }
    public class Fan
    {
        public const int SLOW = 0;
        public const int MEDIUM = 1;
        public const int FAST = 2;

        private int speed;
        private bool on;
        private double radius;
        private string color;

        public Fan()
        {
            speed = SLOW;
            on = false;
            radius = 5;
            color = "blue";
        }

        public int Speed { get => speed; set => speed = value; }
        public bool On { get => on; set => on = value; }
        public double Radius { get => radius; set => radius = value; }
        public string Color { get => color; set => color = value; }
        public override string ToString()
        {
            if (on)
            {
                return $"Fan is on: Speed = {speed}, Color = {color}, Radius = {radius}";
            }
            else
            {
                return $"Fan is off: Color = {color}, Radius = {radius}";
            }
        }
    }
}
