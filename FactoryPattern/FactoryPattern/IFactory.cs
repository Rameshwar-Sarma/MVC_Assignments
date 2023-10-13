
namespace FactoryPattern
{
    public interface IFactory
    {
        IVehicle GetVehicle(string vehicle);
    }
}
