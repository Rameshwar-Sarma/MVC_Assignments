using System;
using System.Text.RegularExpressions;
using DataModel;

namespace BussinessLogicLayer
{
    public class BLLAuthentication
    {
        public bool NewUserInput(UserInformation userInfoObj)
        {
            BLLValidation validObj = new BLLValidation();
            Regex userNameRgxObj = new Regex("^[A-Za-z][A-Za-z0-9_]{7,29}$");
            Regex passwordRgxObj = new Regex("^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d).{6,15}$");
            Regex emailRgxObj = new Regex("^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\\.[A-Za-z]{2,}$");
            Console.WriteLine();
            if (!userNameRgxObj.IsMatch(userInfoObj.UserName))
            {
                Console.WriteLine(Literals.UserNameRules);
            }
            if (!passwordRgxObj.IsMatch(userInfoObj.Password))
            {
                Console.WriteLine(Literals.PasswordRules);
            }
            if (!emailRgxObj.IsMatch(userInfoObj.Email))
            {
                Console.WriteLine(Literals.EmailRules);
                return false;
            }
            else
            {
                return validObj.NewUser(userInfoObj);
            }
        }
        public bool Login(UserInformation userInfoObj)
        {
            BLLValidation validObj = new BLLValidation();
            Regex userNameRgxObj = new Regex("^[A-Za-z][A-Za-z0-9_]{7,29}$");
            Regex passwordRgxObj = new Regex("^[A-Za-z0-9][A-Za-z0-9_]{5,}$");
            if (!userNameRgxObj.IsMatch(userInfoObj.UserName) || !passwordRgxObj.IsMatch(userInfoObj.Password))
            {
                Console.WriteLine(Literals.UserNameOrPassword);
                return false;
            }
            else
            {
                return validObj.LoginUser(userInfoObj);
            }
        }
    }
}

