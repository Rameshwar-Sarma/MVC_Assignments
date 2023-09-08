using System;

namespace FixedScope
{
    /// <summary>
    /// this class describes the behaviour and properties of a student 
    /// </summary>
    public class Student
    {
        // Student Id and Name are declared and initilaized as static fields.
        public static int Id = 10;
        public static String Name = "Peter";

        /// <summary>
        /// The 'PrintDetails' method intended to print the details of a student.
        /// </summary>
        public void PrintDetails()
        {
            Console.WriteLine("Identity of the Student is : " + Student.Id);
            Console.WriteLine("Name of the Student is : " + Student.Name);
            Console.WriteLine();
        }
    }
} 
