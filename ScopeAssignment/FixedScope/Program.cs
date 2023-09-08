using System;

namespace FixedScope
{
    /// <summary>
    /// This project aim is to know the Scope of the Static fields
    /// inside and outside of the project.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Main method starts here
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            // Creating a student object 
            Student student = new Student();

            Console.WriteLine("The Initial Details of the Student is ");
            student.PrintDetails();

            //the details of student are changed here
            Student.Id = 25;
            Student.Name = "John";

            Console.WriteLine("The Changed Details of the Student is ");
            student.PrintDetails();

            Console.ReadLine();
        }

    }
}
