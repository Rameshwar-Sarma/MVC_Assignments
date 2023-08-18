using System;

namespace Solution1
{
    internal class Program
    {
        /// <summary>
        /// Main Method Starts Here
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // Creation of firstObject
            DuplicateCreation firstObject = new DuplicateCreation();

            Console.WriteLine(" The Initial Generation of firstObject is :" + GC.GetGeneration(firstObject));
            
            GenerationShift shift = new GenerationShift();

            // Converting Generations 
            shift.ConvertGeneration(firstObject, GC.GetGeneration(firstObject));
            shift.ConvertGeneration(firstObject, GC.GetGeneration(firstObject));

            Console.ReadLine();
            

        }
    }
    class DuplicateCreation { }
}

