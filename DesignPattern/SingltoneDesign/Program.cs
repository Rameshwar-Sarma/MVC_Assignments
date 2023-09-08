using System;

namespace DesignPattern

{
    /// <summary>
    /// This program intention is to use the Single Design Pattern.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
             // creating a singletonObj for the Singleton Class using GetInstance method.
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
