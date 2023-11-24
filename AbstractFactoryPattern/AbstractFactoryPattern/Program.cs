using System;

namespace AbstractFactoryPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int style, furniture;
            do
            {
                Console.WriteLine("Please select your furniture style:");
                Console.WriteLine("[1]Classic, [2]Contemporary, [3]Scandinavian");
                int.TryParse(Console.ReadLine(), out style);
            }
            while (style == 0 || style > 3);
            IFurnitureFactory Factory = null;
            switch (style)
            {
                case 1:
                    Factory = new ClassicFurnitureFactory();
                    break;
                case 2:
                    Factory = new ContemporaryFurnitureFactory();
                    break;
                case 3:
                    Factory = new ScandinavianFurnitureFactory();
                    break;
            }
            do
            {
                Console.WriteLine("Please select your furniture :");
                Console.WriteLine("[1]Cabinet, [2]Chair, [3]Dining Table");
                int.TryParse(Console.ReadLine(), out furniture);
            }
            while (furniture == 0 || furniture > 3);
            IFurniture furnitureProduct = null;
            switch (furniture)
            {
                case 1:
                    furnitureProduct = Factory.CreateCabinet();
                    break;
                case 2:
                    furnitureProduct = Factory.CreateChair();
                    break;
                case 3:
                    furnitureProduct = Factory.CreateDiningTable();
                    break;
            }
            Console.WriteLine("Furniture Created: ");
            furnitureProduct.ShowStyle();
            furnitureProduct.FurnitureFunction();
            Console.ReadLine();
        }
    }
}
