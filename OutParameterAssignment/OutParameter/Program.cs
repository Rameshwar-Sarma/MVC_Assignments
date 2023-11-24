using System;
using System.Threading;
namespace OutParameter
{
    internal class Program
    {

        int valueC;
        static void Main(string[] args)
        {
            int valueA = 10;
            int valueB = 20;
            Program programObj = new Program();
            CheckDefault check = new CheckDefault();

            Thread thread1 = new Thread(() => check.Add(valueA, valueB, out programObj.valueC));
            Thread thread2 = new Thread(() => check.PrintValue(programObj.valueC));

            thread1.Start();
            thread2.Start();
            
            Console.ReadLine();
        }
    }
}
