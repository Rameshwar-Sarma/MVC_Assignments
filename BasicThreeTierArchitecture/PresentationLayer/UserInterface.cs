using BussinessLogicLayer;
using DataModel;
using System;

namespace PresentationLayer
{
    public class UserInterface
    {
        /// <summary>
        /// Registration for new user
        /// </summary>
        public int NewUserData()
        {
            BLLAuthentication bllObj = new BLLAuthentication();
            UserInput inputObj = new UserInput();
            UserInformation userObj = new UserInformation();

            Console.WriteLine(Literals.Welcome);
            userObj = inputObj.ReadUserName(userObj);
            userObj = inputObj.ReadPassword(userObj);
            userObj = inputObj.ReadEmail(userObj);
            userObj = inputObj.ReadConfirmPassword(userObj);

            if (bllObj.RegisterAuthentication(userObj))
            {
                Console.Clear();
                Console.WriteLine(Literals.Welcome);
                Console.WriteLine();
                Console.WriteLine(Literals.SuccessfulRegistration);
                int response = inputObj.OnSucceessfulRegistration();
                return response;
            }
            else
            {
                Console.Clear();
                Console.WriteLine(Literals.RegistrationFailed);
                return 0;
            }
        }
        /// <summary>
        /// UserLoginData for existing user.
        /// </summary>
        public int UserLoginData()
        {
            Console.WriteLine(Literals.Welcome);
            int response = 0;
            UserInput inputObj = new UserInput();
            BLLValidation bllObj = new BLLValidation();
            UserInformation userObj = new UserInformation();

            userObj = inputObj.ReadUserName(userObj);
            userObj = inputObj.ReadPassword(userObj);

            if (bllObj.LoginUser(userObj))
            {
                Console.Clear();
                Console.WriteLine(Literals.Welcome);
                Console.WriteLine();
                Console.WriteLine(Literals.SuccessfulLogin);
                Console.WriteLine();
                response = inputObj.OnSuccessfulLogin();
            }
            else
            {
                char YesOrNo = inputObj.OnFailedLogin();
                if (YesOrNo == 'y')
                {
                    UserPasswordChange();
                }
                else if (YesOrNo == 'n')
                {
                    UserLoginData();
                }
            }
            return response;
        }
        /// <summary>
        /// Change of password, if in case user forgot password.
        /// </summary>
        public void UserPasswordChange()
        {

            UserInput inputObj = new UserInput();
            BLLValidation bllValidObj = new BLLValidation();
            UserInformation userObj = new UserInformation();

            Console.Write(Literals.EnterUserName);
            userObj = inputObj.ReadUserName(userObj);

            if (bllValidObj.ExistUser(userObj))
            {
                Console.Write(Literals.EnterNewPassword);
                userObj = inputObj.ReadPassword(userObj);
                Console.Write(Literals.ConfirmPassword);
                userObj = inputObj.ReadConfirmPassword(userObj);

                bllValidObj.ChangeUserPassword(userObj);
                Console.WriteLine(Literals.PasswordChanged);
            }
            else
            {
                Console.WriteLine(Literals.UsernameNotFound);
            }
        }
    }
}
