using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();


            class1 ref1 = new class1();
            int no_of_iterations1 = 0, no_of_iterations2 = 0;
            Console.WriteLine(" before loops, Generation is :" + GC.GetGeneration(ref1));
            stopwatch.Start();
            while (GC.GetGeneration(ref1) == 0)
            {
                class2 ref2 = new class2();
                no_of_iterations1++;
            }
            stopwatch.Stop();
            TimeSpan timestamp1 = stopwatch.Elapsed;

            Console.WriteLine("Iterations from Gen0 to Gen1 :" + no_of_iterations1);
            Console.WriteLine($"RunTime from Gen 0 to Gen 1 :{timestamp1.TotalMilliseconds} ms");
            Console.WriteLine("after first Loop, Generation is :" + GC.GetGeneration(ref1));


            stopwatch.Restart();
            while (GC.GetGeneration(ref1) == 1)
            {
                class2 ref2 = new class2();
                no_of_iterations2++;
            }
            stopwatch.Stop();
            TimeSpan timestamp2 = stopwatch.Elapsed;
            Console.WriteLine("Iterations from Gen1 to Gen2 :" + no_of_iterations2);
            Console.WriteLine($"RunTime from Gen 1 to Gen 2 : {timestamp2.TotalMilliseconds} ms");
            Console.WriteLine("after second Loop, Generation is :" + GC.GetGeneration(ref1));
            Console.ReadLine();
        }
    }
    class class1 { }
    class class2 { }
}


