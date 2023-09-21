using System;

namespace SubString
{
    /// <summary>
    /// this Program intention is to find the positions of all the SubStrings in a Given String
    /// </summary>
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a String :");
            String word = Console.ReadLine();

            Console.Write("Enter the SubString :");
            String pattern = Console.ReadLine();

            int wordSize = word.Length;
            int patternSize = pattern.Length;
            int counter = 0;
            String IndexPositions = "";

            PatternCheck check = new PatternCheck();

            for (int index = 0; index < (wordSize - patternSize); index++)
            {
                // Checking wheather valid substring or not
                if (check.isValid(word, pattern, patternSize, index))
                {
                    counter++;
                    IndexPositions += index + " ";
                }
            }
            if (counter == 0)
            {
                Console.WriteLine("No SubString Found");
            }
            else
            {
                Console.WriteLine("Number of times SubString Occured in a String :" + counter);
                Console.WriteLine("Index Positions of Substring are :" + IndexPositions);
            }
            Console.ReadLine();
        }
    }
}


