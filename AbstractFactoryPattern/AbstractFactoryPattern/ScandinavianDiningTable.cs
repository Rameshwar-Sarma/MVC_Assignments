using System;

namespace AbstractFactoryPattern
{
    public class ScandinavianDiningTable : IFurniture
    {
        public void FurnitureFunction()
        {
            Console.WriteLine("I'm used for eating food");
        }
        public void ShowStyle()
        {
            Console.WriteLine("I'm a Scandinavian Dining Table ");
        }
    }
}
