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
            UserInput inputObj = new UserInput();

            Console.WriteLine(Literals.Welcome);
            do
            {
                response = inputObj.MainMenuInput();
                Console.Clear();
                Console.WriteLine();
                if (response == 1)
                {
                    response = userInterfaceObj.NewUserData();
                }
                if (response == 2)
                {
                    response = userInterfaceObj.UserLoginData();
                }
            } while (response != 3);
        }


    }
}

