using BussinessLogicLayer;
using DataModel;
using System;

namespace PresentationLayer
{
    public class UserInterface
    {
        /// <summary>
        /// New Registrstion of a user
        /// </summary>
        /// <param name="UserName"></param>
        public int Register()
        {
            int response = 0;
            UserInformation userInfoObj = new UserInformation();
            BLLAuthentication bllObj = new BLLAuthentication();

            Console.Write(Literals.EnterUserName);
            userInfoObj.UserName = Console.ReadLine();
            Console.Write(Literals.EnterEmail);
            userInfoObj.Email = Console.ReadLine();
            Console.Write(Literals.EnterPassword);
            userInfoObj.Password = Console.ReadLine();
            Console.Write(Literals.ConfirmPassword);
            userInfoObj.ConfirmPassword = Console.ReadLine();

            if (bllObj.NewUserInput(userInfoObj))
            {
                Console.WriteLine(Literals.SuccessfulRegistration);
                do
                {
                    Console.WriteLine(Literals.RegistrationOptions);
                    Console.WriteLine(Literals.SelectOption);
                    response = Convert.ToInt32(Console.ReadLine());
                } while (response < 1 && response > 3);
                return response;
            }
            else
            {
                Console.WriteLine(Literals.RegistrationFailed);
                return 0;
            }
        }
        /// <summary>
        /// user login with credentials
        /// </summary>
        /// <param name="UserName"></param>
        public int Login()
        {
            int response = 0;
            UserInformation userInfoObj = new UserInformation();
            BLLValidation bllObj = new BLLValidation();

            Console.Write(Literals.EnterUserName);
            userInfoObj.UserName = Console.ReadLine();
            Console.Write(Literals.EnterPassword);
            userInfoObj.Password = Console.ReadLine();

            if (bllObj.LoginUser(userInfoObj))
            {
                Console.WriteLine(Literals.SuccessfulLogin);
                do
                {
                    Console.WriteLine(Literals.LogoutOption);
                    Console.WriteLine(Literals.SelectOption);
                    response = Convert.ToInt32(Console.ReadLine());
                } while (response != 1);
            }
            else
            {
                Console.WriteLine(Literals.UserNameOrPassword);
                Console.WriteLine(Literals.ForgotPassword);
                char YesOrNo = Convert.ToChar(Console.ReadLine().ToLower());
                if(YesOrNo == 'y')
                {
                    ForgotPassword();
                }
                else if(YesOrNo == 'n')
                {
                    Login();
                }
            }
            return response;
        }
        /// <summary>
        /// Change of password, if in case user forgot password.
        /// </summary>
        public void ForgotPassword()
        {
            UserInformation userInfoObj = new UserInformation();
            BLLAuthentication bllObj = new BLLAuthentication();
            BLLValidation bllValidObj = new BLLValidation();

            Console.Write(Literals.EnterUserName);
            userInfoObj.UserName = Console.ReadLine();

            if (bllValidObj.ExistUser(userInfoObj))
            {
                Console.Write(Literals.EnterNewPassword);
                userInfoObj.Password = Console.ReadLine();
                Console.Write(Literals.ConfirmPassword);
                userInfoObj.ConfirmPassword = Console.ReadLine();

                bllValidObj.ChangeUserPassword(userInfoObj);
                Console.WriteLine(Literals.PasswordChanged);
            }
            else
            {
                Console.WriteLine(Literals.UsernameNotFound);
            }
        }
    }
}



