using System;

namespace BuildPattern
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            ToyCreator toyACreator = new ToyCreator(new ToyABuilder());
            toyACreator.CreateToy();
            Toy t1 = toyACreator.GetToy();
            Console.WriteLine($"the Model of the toy is {t1.Model}");
            ToyCreator toyBCreator = new ToyCreator(new ToyBBuilder());
            toyBCreator.CreateToy();
            Toy t2 = toyBCreator.GetToy();
            Console.WriteLine($"the Model of the toy is {t2.Model}");
            Console.ReadLine();
        }
    }
}
