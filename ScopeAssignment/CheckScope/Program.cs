using System;
using FixedScope;

namespace CheckScope
{
    /// <summary>
    /// This program is to check the scope of static fields of "FixedScope".
    /// </summary>
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Identity of the Student is : " + Student.Id);
            Console.WriteLine("Name of the Student is : " + Student.Name);
            Console.ReadLine();
        }
    }
}
