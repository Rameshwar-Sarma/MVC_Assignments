using System;

namespace AbstractFactoryPattern
{
    public class ContemporaryDiningTable : IFurniture
    {
        public void FurnitureFunction()
        {
            Console.WriteLine("I'm used for eating food");
        }
        public void ShowStyle()
        {
            Console.WriteLine("I'm a Contemporary Dining Table ");
        }
    }
}
