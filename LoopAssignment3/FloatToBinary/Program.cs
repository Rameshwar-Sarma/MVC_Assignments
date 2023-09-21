using System;

namespace FloatToBinary
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the First Float Number :");
            float valueA = float.Parse(Console.ReadLine());

            Console.Write("Enter the Second Float Number :");
            float valueB = float.Parse(Console.ReadLine());

            Conversions convertObj = new Conversions();

            // converting decimal values to binary value using FinalValue Method
            double FinalDecimalValue = convertObj.FinalValue(valueA, valueB);

            Console.WriteLine("Final Float Value is :" + FinalDecimalValue);
            Console.ReadLine();
        }
    }
}

