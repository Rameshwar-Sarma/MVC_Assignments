using System;

namespace FixedScope
{
    /// <summary>
    /// The project is to know the Scope of the Static fields in assembly level.
    /// </summary>
    public class Program
    {
        static void Main(string[] args)
        {
            Student studentObj = new Student();

            Console.WriteLine("The Initial Details of the Student is ");
            studentObj.DisplayInfo();

            Student.Id = 25;
            Student.Name = "John";

            Console.WriteLine("The Changed Details of the Student is ");
            studentObj.DisplayInfo();
            Console.ReadLine();
        }

    }
}
