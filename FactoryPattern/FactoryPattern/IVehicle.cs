

namespace FactoryPattern
{
    public interface IVehicle
    {
        int NoOfWheels { get; set; }
        void Drive();
    }
}
