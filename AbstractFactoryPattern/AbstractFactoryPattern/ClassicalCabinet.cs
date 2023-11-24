using System;
using System.Collections.Generic;

namespace AbstractFactoryPattern
{
    public class ClassicalCabinet : IFurniture
    {
        public void FurnitureFunction()
        {
            Console.WriteLine("I'm used for storing item");
        }
        public void ShowStyle()
        {
            Console.WriteLine("I'm a Classical cabinet ");
        }
    }
}
