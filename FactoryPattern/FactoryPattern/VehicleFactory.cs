using System;

namespace FactoryPattern
{
    public class VehicleFactory : IFactory
    {
        public IVehicle GetVehicle(string vehicle)
        {
            switch (vehicle)
            {
                case "car":
                    return new Car();
                case "bike":
                    return new Bike();
                default:
                    throw new Exception(string.Format("Vehicle '{0}' cannot be created", vehicle));
            }
        }
    }
}
