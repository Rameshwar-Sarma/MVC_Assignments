using System;

namespace GreatestProduct
{
    public class Program
    {
        static void Main(string[] args)
        {
            String Numbers;
            int StartIndex, MaxProduct = 1 ;
            do
            {
                Console.Write("Please enter atleast 4 digits :");
                Numbers = Console.ReadLine();
            } while (Numbers.Length < 4);

            Multiplication multiplyObj = new Multiplication();

            StartIndex = multiplyObj.FindIndex(Numbers, ref MaxProduct);

            Console.WriteLine("The Greatest Product of 4 multiples is :" +
                               Numbers[StartIndex] + " * " + Numbers[StartIndex + 1] + " * " +
                               Numbers[StartIndex + 2] + " * " + Numbers[StartIndex + 3] + " = " +
                               MaxProduct);
            Console.ReadLine();
        }
    }
}

