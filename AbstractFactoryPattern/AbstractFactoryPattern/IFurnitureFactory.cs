
namespace AbstractFactoryPattern
{
    public interface IFurnitureFactory
    {
        IFurniture CreateCabinet();
        IFurniture CreateChair();
        IFurniture CreateDiningTable();
    }
}
