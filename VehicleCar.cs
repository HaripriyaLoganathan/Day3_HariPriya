using System;
namespace VehicleCar
{
    class Vehicle
    {
        public void Display()
        {
            Console.WriteLine("This is a Vehicle class");
        }
    }
    class Car :Vehicle
    {
        void Color()
        {
            Console.WriteLine("Color of a Car is Silver Grey...");
        }
        static void Main(string[] args)
        {
            Car co = new Car();
            co.Display();
            co.Color();
            Console.Read();
        }
    }
}

