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
             Singleton singletonObjA = Singleton.GetInstance();
             Singleton singletonObjB = Singleton.GetInstance();

            singletonObjA.UsePattern();
            singletonObjB.UsePattern();
            singletonObjA.ReleasePattern();
            singletonObjB.UsePattern();
            singletonObjA.ReleasePattern();

            Console.ReadLine();
        }
    }
}
