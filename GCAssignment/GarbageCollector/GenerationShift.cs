using System;
using System.Diagnostics;


namespace GarbageCollector
{
    internal class GenerationShift
    {
        /// <summary>
        /// This method calculates the time taken for "instanceA" to move the Generations
        /// </summary>
        /// <param name="instanceA"></param>
        /// <param name="CurrentGeneration"></param>
        public void NextGeneration(Duplicate instanceA, ref int CurrentGeneration)
        {
            //Stopwatch is used to note the start and stop timings
            Stopwatch stopwatch = Stopwatch.StartNew();

            stopwatch.Start();

            while (GC.GetGeneration(instanceA) == CurrentGeneration)
            {
                Duplicate duplicate = new Duplicate();
            }

            stopwatch.Stop();

            //TimeSpan is used to calculate the time stamp between stopwatch laps.
            TimeSpan timestamp = stopwatch.Elapsed;
            CurrentGeneration++;

            Console.WriteLine($"RunTime from Gen {CurrentGeneration-1} to Gen {CurrentGeneration} is :{timestamp.TotalMilliseconds} milliSeconds");
            Console.WriteLine(" The CurrentGeneration of instanceA is : " + GC.GetGeneration(instanceA));
        }
    }
    /// <summary>
    /// This class is used to create a Duplicate Objects to know the 
    /// generations of a Particular Object.
    /// </summary>
    class Duplicate { }
}

