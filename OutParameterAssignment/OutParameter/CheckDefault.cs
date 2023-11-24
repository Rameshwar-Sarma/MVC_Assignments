using System;
using System.Threading;

namespace OutParameter
{
    internal class CheckDefault
    {
        public void Add(int valueA, int valueB, out int valueC)
        {
            Thread.Sleep(1000);
            valueC = valueA + valueB;
        }
        public void PrintValue(int value)
        {
            Console.WriteLine(value);
        }
    }
}
