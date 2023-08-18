using System;
using System.Diagnostics;


namespace Solution1
{
    internal class GenerationShift
    {
        /// <summary>
        /// ConvertGeneration method starts here
        /// </summary>
        /// <param name="firstObject"></param>
        /// <param name="Generation"></param>
        public void ConvertGeneration(DuplicateCreation firstObject, int Generation)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            stopwatch.Start();
            while (GC.GetGeneration(firstObject) == Generation)
            {
                DuplicateCreation duplicates = new DuplicateCreation();
            }
            stopwatch.Stop();
            TimeSpan timestamp = stopwatch.Elapsed;

            Console.WriteLine(" The Generation of firstObject is :" + GC.GetGeneration(firstObject));
            Console.WriteLine($"RunTime from Gen {Generation} to Gen {Generation+1} :{timestamp.TotalMilliseconds} milliSeconds");
        }
    }
}
