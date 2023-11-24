using System;

namespace AbstractFactoryPattern
{
    public class ClassicalDiningTable : IFurniture
    {
        public void FurnitureFunction()
        {
            Console.WriteLine("I'm used for eating food");
        }
        public void ShowStyle()
        {
            Console.WriteLine("I'm a Classical Dining Table ");
        }
    }
}
