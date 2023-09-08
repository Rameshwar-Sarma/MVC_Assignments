using System;

namespace GarbageCollector
{
    /// <summary>
    /// This Project intention is to Calculate the time taken for an object to move between
    /// Generations of a Garbage Collector.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Main Method Execution starts here.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // the initial Generation of an object is zero.
            int Generation = 0;

            // Creation of instanceA object to find the generation shifts for this object.
            Duplicate instanceA = new Duplicate();

            Console.WriteLine(" The Initial Generation of 'instanceA' is :" + GC.GetGeneration(instanceA));

            GenerationShift shift = new GenerationShift();

            // Shifting the Generations of 'instanceA' from 0 to 1.
            shift.NextGeneration(instanceA, ref Generation);

            // Shifting the Generations of 'instanceA' from 1 to 2.
            shift.NextGeneration(instanceA, ref Generation);

            Console.ReadLine();


        }
    }

}