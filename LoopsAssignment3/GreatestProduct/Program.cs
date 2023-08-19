using System;

namespace GreatestProduct
{
    internal class Program
    {
        /// <summary>
        /// Main Method starts here
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // declaring local varibles to the Main method
            String Numbers;
            int endIndex, GreatestProduct;

            // input loop, until valid input is given 
            do
            {
                // Reading input from user
                Console.Write("Please enter atleast 4 digits :");
                Numbers = Console.ReadLine();
            } while (Numbers.Length < 4);

            // Declaring a pre defined array for multiplication
            int[] preDefined = new int[Numbers.Length];

            // precompute object created
            PreComputeProduct precompute = new PreComputeProduct();

            // filling the preCompute array with product from index 0 to current index
            precompute.FillPreDefined(ref preDefined, Numbers);
            GreatestProduct = preDefined[3];

            // finding the greatest Product
            endIndex = precompute.FindProductIndex(preDefined, Numbers, ref GreatestProduct);

            // Printing the final Greatest Product
            Console.WriteLine("The Greatest Product of 4 multiples is :" +
                               Numbers[endIndex - 3] + " * " + Numbers[endIndex - 2] + " * " +
                               Numbers[endIndex - 1] + " * " + Numbers[endIndex]     + " = " + 
                               GreatestProduct);
            Console.ReadLine();
        }
    }
}
