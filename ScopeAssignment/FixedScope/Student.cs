using System;

namespace FixedScope
{
    /// <summary>
    /// This class describes the behaviour and properties of a student 
    /// </summary>
    public class Student
    {
        public static int Id = 10;
        public static String Name = "Peter";
        public void DisplayInfo()
        {
            Console.WriteLine("Identity of the Student is : " + Student.Id);
            Console.WriteLine("Name of the Student is : " + Student.Name);
            Console.WriteLine();
        }
    }
} 
