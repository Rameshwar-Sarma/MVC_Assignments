using FindSubString;
using System;

namespace SubString
{
    internal class Program
    {
        /// <summary>
        /// Main Method starts here
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // Reading full string as input from user
            Console.Write("Enter a String :");
            String word = Console.ReadLine();

            // Reading substring as input from user
            Console.Write("Enter the SubString :");
            String pattern = Console.ReadLine();

            // Variables Declaration and Assignment
            int wordLength = word.Length;
            int patternLength = pattern.Length;
            int noOfTimesOccured = 0;
            String IndexPositions = "";

            // StringValidation object created
            StringValidation valid = new StringValidation();


            for (int loop = 0; loop < wordLength - patternLength; loop++)
            {
                // Checking wheather valid substring or not
                if (valid.isSubString(word, wordLength, pattern, patternLength, loop))
                {
                    noOfTimesOccured++;
                    IndexPositions += loop + " ";
                }

            }
            Console.WriteLine("No_of_times_Occured :" + noOfTimesOccured);
            Console.WriteLine("Index Positions are :" + IndexPositions);
            Console.ReadLine();

        }
    }
}

