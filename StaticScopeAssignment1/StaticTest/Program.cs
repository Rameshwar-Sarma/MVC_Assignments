using System;

namespace AdminValidation
{
    /// <summary>
    /// College admin validation the initial assignment of a branch CSE
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Main Method starts here
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // College Admin Checking the initial Assignemnt of CSE Students
            Console.WriteLine(CSEAssignemnts.Program.noOfStudents);
            Console.WriteLine(CSEAssignemnts.Program.AssignmentName);

            Console.ReadLine();
        }
    }
}
