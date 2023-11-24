using System;

namespace AbstractFactoryPattern
{
    public class ClassicalChair : IFurniture
    {
        public void FurnitureFunction()
        {
            Console.WriteLine("I'm used for sitting");
        }
        public void ShowStyle()
        {
            Console.WriteLine("I'm a Classical chair ");
        }
    }
}
