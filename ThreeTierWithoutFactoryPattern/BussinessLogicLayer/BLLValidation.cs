using System;
using DataAccessLayer;
using DataModel;

namespace BussinessLogicLayer
{
    public class BLLValidation
    {
        public bool NewUser(UserInformation userInfoObj)
        {
            if (userInfoObj.Password == userInfoObj.ConfirmPassword)
            {
                DataAccess dataObj = new DataAccess();
                if (dataObj.HasUser(userInfoObj))
                {
                    Console.WriteLine(Literals.AlreadyExists);
                }
                if (dataObj.EmailRegistered(userInfoObj))
                {
                    Console.WriteLine(Literals.EmailRegistered);
                    return false;
                }
                return dataObj.AddNewUser(userInfoObj);
            }
            else
            {
                Console.WriteLine(Literals.PasswordNotMatched);
                return false;
            }
        }
        public bool ExistUser(UserInformation userInfoObj)
        {
            DataAccess dataObj = new DataAccess();
            return dataObj.HasUser(userInfoObj);
        }
        public bool LoginUser(UserInformation userInfoObj)
        {
            DataAccess dataObj = new DataAccess();
            return dataObj.ValidUser(userInfoObj);
        }
        public bool ChangeUserPassword(UserInformation userInfoObj)
        {
            if (userInfoObj.Password == userInfoObj.ConfirmPassword)
            {
                DataAccess dataObj = new DataAccess();
                return dataObj.NewPassword(userInfoObj);
            }
            else
            {
                Console.WriteLine(Literals.PasswordNotMatched);
                return false;
            }

        }
    }

}


