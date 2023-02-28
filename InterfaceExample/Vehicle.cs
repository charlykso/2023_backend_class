using System;

namespace InterfaceExample
{
    public class Vehicle : IVehicle 
    {
        public string? name;
        public string? model;
        public double price;

        public void hunk()
        {
            Console.WriteLine("hunking");
        }

        public void move()
        {
            Console.WriteLine("moving");
        }
    }

    enum level{
        Low,
        Midium,
        High
    }
}
