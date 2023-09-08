using System;

namespace FloatToBinary
{
    /// <summary>
    /// This Project aims to Convert the Float values to the Binary values, 
    /// add them and again Converted to Flaot Values
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the First Float Number :");
            float valueA = float.Parse(Console.ReadLine());

            Console.Write("Enter the Second Float Number :");
            float valueB = float.Parse(Console.ReadLine());

            Conversions convert = new Conversions();

            // converting decimal values to binary value using FinalValue Method
            double FinalDecimalValue = convert.FinalValue(valueA, valueB);

            Console.WriteLine("Final Float Value is :" + FinalDecimalValue);
            Console.ReadLine();
        }
    }
}

