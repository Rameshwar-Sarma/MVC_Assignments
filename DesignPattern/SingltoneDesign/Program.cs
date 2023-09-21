using System;

namespace DesignPattern

{
    /// <summary>
    /// This program intention is to use the Single Design Pattern.
    /// </summary>
    public class Program
    {
        static void Main(string[] args)
        {
             Singleton singletonObj = Singleton.GetInstance();

            singletonObj.UsePattern();
            singletonObj.UsePattern();
            singletonObj.ReleasePattern();
            singletonObj.UsePattern();
            singletonObj.ReleasePattern();

            Console.ReadLine();
        }
    }
}
