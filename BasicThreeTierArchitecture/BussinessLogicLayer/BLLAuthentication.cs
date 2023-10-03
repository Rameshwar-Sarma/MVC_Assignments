using System;
using System.Text.RegularExpressions;
using DataModel;

namespace BussinessLogicLayer
{
    public class BLLAuthentication
    {
        public bool NewUserInput(UserInformation userObj)
        {
            BLLValidation validObj = new BLLValidation();
            Console.WriteLine();
            bool isValidUserName = ValidUsername(userObj);
            bool isValidPassword = ValidPassword(userObj);
            bool isValidEmail = ValidEmail(userObj);
            bool isValidConfirmPassword = ValidConfirmPassword(userObj);
            if (isValidUserName && isValidPassword && isValidEmail && isValidConfirmPassword)
            {
                return validObj.NewUser(userObj);
            }
            return false;
        }
        public bool Login(UserInformation userObj)
        {
            BLLValidation validObj = new BLLValidation();
            bool isValidUserName = ValidUsername(userObj);
            bool isValidPassword = ValidPassword(userObj);
            if (isValidUserName && isValidPassword)
            {
                return validObj.NewUser(userObj);
            }
            return false;
        }
        public bool ValidUsername(UserInformation userInfoObj)
        {
            Regex userNameRgxObj = new Regex("^[A-Za-z][A-Za-z0-9_]{7,29}$");
            if (!userNameRgxObj.IsMatch(userInfoObj.UserName))
            {
                Console.WriteLine(Literals.UserNameRules);
                return false;
            }
            return true;
        }
        public bool ValidPassword(UserInformation userInfoObj)
        {
            Regex passwordRgxObj = new Regex("^[A-Za-z0-9!@#$%^&*]{6,}$");
            if (!passwordRgxObj.IsMatch(userInfoObj.Password))
            {
                Console.WriteLine(Literals.PasswordRules);
                return false;
            }
            return true;
        }
        public bool ValidEmail(UserInformation userInfoObj)
        {
            Regex emailRgxObj = new Regex("^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\\.[A-Za-z]{2,}$");
            if (!emailRgxObj.IsMatch(userInfoObj.Email))
            {
                Console.WriteLine(Literals.EmailRules);
                return false;
            }
            return true;
        }
        public bool ValidConfirmPassword(UserInformation userInfoObj)
        {
            Regex passwordRgxObj = new Regex("^[A-Za-z0-9!@#$%^&*]{6,}$");
            if (!passwordRgxObj.IsMatch(userInfoObj.ConfirmPassword))
            {
                return false;
            }
            return true;
        }
    }
}
