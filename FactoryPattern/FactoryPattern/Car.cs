using System;


namespace FactoryPattern
{
    internal class Car : IVehicle
    {
        public int NoOfWheels { get; set;}
        public Car() 
        {
            NoOfWheels = 4;
        }
        public void Drive()
        {
            Console.WriteLine($"car drives with {NoOfWheels} wheels !!!");
        }
    }
}
