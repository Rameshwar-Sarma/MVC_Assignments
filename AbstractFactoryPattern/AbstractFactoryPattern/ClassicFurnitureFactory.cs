
namespace AbstractFactoryPattern
{
    public class ClassicFurnitureFactory :IFurnitureFactory
    {
        public IFurniture CreateCabinet()
        {
            return new ClassicalCabinet();
        }
        public IFurniture CreateChair()
        {
            return new ClassicalChair();
        }
        public IFurniture CreateDiningTable()
        {
            return new ClassicalDiningTable();
        }
    }
}
