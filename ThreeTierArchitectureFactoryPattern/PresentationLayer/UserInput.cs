using DataModel;
using System;

namespace PresentationLayer
{
    public class UserInput
    {
        public int MainMenuInput()
        {
            int response = 0;
            try
            {
                Console.WriteLine(Literals.MainMenu);
                Console.Write(Literals.SelectOption);
                response = Convert.ToInt32(Console.ReadLine());
                if (response > 0 && response < 4)
                {
                    return response;
                }

            }
            catch
            {
                Console.WriteLine();
                Console.WriteLine(Literals.ValidInput);
            }
            return MainMenuInput();
        }
        public UserInformation ReadUserName(UserInformation userObj)
        {
            Console.Write(Literals.EnterUserName);
            userObj.UserName = Console.ReadLine();
            if (userObj.UserName == null || userObj.UserName == "")
            {
                Console.WriteLine(Literals.NonEmptyField);
                return ReadUserName(userObj);
            }
            return userObj;
        }
        public UserInformation ReadPassword(UserInformation userObj)
        {
            
            Console.Write(Literals.EnterPassword);
            userObj.Password = Console.ReadLine();
            if (userObj.Password == null || userObj.Password == "")
            {
                Console.WriteLine(Literals.NonEmptyField);
                return ReadPassword(userObj);
            }
            return userObj;

        }
        public UserInformation ReadEmail(UserInformation userObj)
        {
            Console.Write(Literals.EnterEmail);
            userObj.Email = Console.ReadLine();
            if (userObj.Email == null || userObj.Email == "")
            {
                Console.WriteLine(Literals.NonEmptyField);
                return ReadEmail(userObj);
            }
            return userObj;

        }
        public UserInformation ReadConfirmPassword(UserInformation userObj)
        {
            Console.Write(Literals.ConfirmPassword);
            userObj.ConfirmPassword = Console.ReadLine();
            if (userObj.ConfirmPassword == null || userObj.ConfirmPassword == "")
            {
                Console.WriteLine(Literals.NonEmptyField);
                return ReadConfirmPassword(userObj);
            }
            return userObj;
        }
        public int OnSucceessfulRegistration()
        {
            int response = 0;

            try
            {
                Console.WriteLine(Literals.RegistrationOptions);
                Console.WriteLine(Literals.SelectOption);
                response = Convert.ToInt32(Console.ReadLine());
                if (response > 0 && response < 4)
                {
                    return response;
                }
            }
            catch
            {
                Console.WriteLine(Literals.ValidInput);
            }
            return OnSucceessfulRegistration();
        }
        public int OnSuccessfulLogin()
        {
            int response = 0;
            try
            {
                Console.Clear();
                Console.WriteLine(Literals.Welcome);
                Console.WriteLine();
                Console.WriteLine(Literals.SuccessfulLogin);
                Console.WriteLine(Literals.LogoutOption);
                Console.WriteLine(Literals.SelectOption);
                response = Convert.ToInt32(Console.ReadLine());
                if (response == 1)
                {
                    return response;
                }
            }
            catch
            {
                Console.WriteLine(Literals.ValidInput);
            }
            return OnSuccessfulLogin();
        }
        public char OnFailedLogin()
        {
            try
            {
                Console.Clear();
                Console.WriteLine(Literals.Welcome);
                Console.WriteLine();
                Console.WriteLine(Literals.UserNameOrPassword);
                Console.WriteLine(Literals.ForgotPassword);
                char YesOrNo = Convert.ToChar(Console.ReadLine().ToLower());
                return YesOrNo;
            }
            catch
            {
                Console.WriteLine(Literals.ValidInput);
            }
            return OnFailedLogin();
        }

    }
}
