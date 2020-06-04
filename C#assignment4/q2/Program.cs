using System;
using System.Collections.Generic;
using System.Text;

namespace assignment4
{
    public abstract class CarAbstract
    {
        public string engine;
        public string tyre;
        public string sound_system;

        public CarAbstract()
        {
            this.engine = "test";
        }
    }

    public class Car : CarAbstract
    {
        private string color;

        public Car(string color)
        {
            this.Color = color;
            this.engine = "fast";
        }

        public void displayColor()
        {
            Console.WriteLine("Color of this car is : {0}",this.Color);
        }

        public string Color { get => color; set => color = value; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("blue");
            Console.WriteLine(car.Color);

        }
    }
}
