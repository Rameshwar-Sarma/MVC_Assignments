
namespace AbstractFactoryPattern
{
    public class ContemporaryFurnitureFactory : IFurnitureFactory
    {
        public IFurniture CreateCabinet()
        {
            return new ContemporaryCabinet();
        }
        public IFurniture CreateChair()
        {
            return new ContemporaryChair();
        }
        public IFurniture CreateDiningTable()
        {
            return new ContemporaryDiningTable();
        }
    }
}
