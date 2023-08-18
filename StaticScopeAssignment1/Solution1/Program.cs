using System;

namespace CSEAssignemnts
{
    /// <summary>
    /// The Assignment and number od students are declared here
    /// </summary>
    public class Program
    {
        // static variables declaration
        public static int noOfStudents = 10;
        public static String AssignmentName = "The World of C#" ;

        /// <summary>
        /// Main method starts here
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Name of the Assignment= " + AssignmentName);
            Console.WriteLine("noOfStudents submitted Assignments = " + noOfStudents);
           
            // Creating a new Assignment using NewAssignment class
            NewAssignment assignment = new NewAssignment();

            //Chaning the Assignment topic
            assignment.ChangeTopic();

            Console.WriteLine("Name of the Changed Assignemnt = " + AssignmentName);
            Console.WriteLine("noOfStudents Submitted new Assignment = " + noOfStudents);
            
            Console.ReadLine();
        }

    }
}

