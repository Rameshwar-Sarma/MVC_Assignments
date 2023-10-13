using System;

namespace FactoryPattern
{
    internal class Bike : IVehicle
    {
        public int NoOfWheels { get; set; }
        public Bike() 
        {
            NoOfWheels = 2;
        }
        public void Drive()
        {
            Console.WriteLine($"Bike drives with {NoOfWheels} wheels");
        }
    }
}
