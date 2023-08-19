using FloatToBinary;
using System;

namespace FloatToBinaryAddition
{
    internal class Program
    {
        /// <summary>
        /// Main Method starts here
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // Reading first float value as input from user
            Console.Write("Enter the First Float Number :");
            float valueA = float.Parse(Console.ReadLine());

            // Reading second float value as input from user
            Console.Write("Enter the Second Float Number :");
            float valueB = float.Parse(Console.ReadLine());

            // object created for Conversions to convert values to required format
            Conversions convert = new Conversions();

            // converting decimal values to binary value using FinalValue Method
            double FinalDecimalValue = convert.FinalValue(valueA, valueB);

            Console.WriteLine("Final Float Value is :" + FinalDecimalValue);     
            Console.ReadLine();
        }
    }
}
