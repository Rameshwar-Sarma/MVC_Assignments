using DataModel;
using System;

namespace PresentationLayer
{
    public class Program
    {
        static void Main(string[] args)
        {
            int response = 0;
            UserInterface userInterfaceObj = new UserInterface();
            Console.WriteLine(Literals.Welcome);
            do
            {
                do
                {
                    Console.WriteLine();
                    Console.WriteLine(Literals.MainMenu);
                    Console.Write(Literals.SelectOption);
                    response = Convert.ToInt32(Console.ReadLine());
                } while(response < 1 && response > 3);

                Console.WriteLine();
                if (response == 1)
                {
                    response = userInterfaceObj.Register();
                }
                if (response == 2)
                {
                    response = userInterfaceObj.Login();
                }
            } while (response != 3);
        }


    }
}

