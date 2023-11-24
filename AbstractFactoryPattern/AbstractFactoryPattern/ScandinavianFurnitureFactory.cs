
namespace AbstractFactoryPattern
{
    public class ScandinavianFurnitureFactory : IFurnitureFactory
    {
        public IFurniture CreateCabinet()
        {
            return new ScandinavianCabinet();
        }
        public IFurniture CreateChair()
        {
            return new ScandinavianChair();
        }
        public IFurniture CreateDiningTable()
        {
            return new ScandinavianDiningTable();
        }
    }
}
