using System;

namespace GreatestProduct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String Numbers;
            int ProductIndex, MaxProduct = 1 ;

            // input loop, until valid input is given 
            do
            {
                Console.Write("Please enter atleast 4 digits :");
                Numbers = Console.ReadLine();
            } while (Numbers.Length < 4);

            Multiplication multiply = new Multiplication();

            // finding the greatest Product
            ProductIndex = multiply.FindIndex(Numbers, ref MaxProduct);

            Console.WriteLine("The Greatest Product of 4 multiples is :" +
                               Numbers[ProductIndex] + " * " + Numbers[ProductIndex + 1] + " * " +
                               Numbers[ProductIndex + 2] + " * " + Numbers[ProductIndex + 3] + " = " +
                               MaxProduct);
            Console.ReadLine();
        }
    }
}

