using System;
using System.Runtime.Remoting.Messaging;

namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            IFactory fact = new VehicleFactory();
            IVehicle vehicleObj = fact.GetVehicle("car");
            vehicleObj.Drive();
            Console.ReadLine();
        }
    }
}
