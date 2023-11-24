using System;

namespace AbstractFactoryPattern
{
    public class ContemporaryCabinet : IFurniture
    {
        public void FurnitureFunction()
        {
            Console.WriteLine("I'm used for storing item");
        }
        public void ShowStyle()
        {
            Console.WriteLine("I'm a Contemporary cabinet ");
        }
    }
}
