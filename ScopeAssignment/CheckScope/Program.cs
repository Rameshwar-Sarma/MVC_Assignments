using System;
using FixedScope;

namespace CheckScope
{
    /// <summary>
    /// This project intention is to check the scope of static fields of "FixedScope" project.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Execution of main method starts here
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            // Checking the values of the static fields of "FixedScope" namespace.
            Console.WriteLine("Identity of the Student is : " + Student.Id);
            Console.WriteLine("Name of the Student is : " + Student.Name);



            Console.ReadLine();
        }
    }
}
