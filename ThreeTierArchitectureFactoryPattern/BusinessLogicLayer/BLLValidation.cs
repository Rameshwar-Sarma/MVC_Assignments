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
                DataFactory factoryObj = new DataFactory();
                IDataAccess dataObj = factoryObj.GetDataAccess();
                if (dataObj.HasUser(userInfoObj))
                {
                    Console.WriteLine(Literals.AlreadyExists);
                    return false;
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
            DataFactory factoryObj = new DataFactory();
            IDataAccess dataObj = factoryObj.GetDataAccess();
            return dataObj.HasUser(userInfoObj);
        }
        public bool LoginUser(UserInformation userInfoObj)
        {
            DataFactory factoryObj = new DataFactory();
            IDataAccess dataObj = factoryObj.GetDataAccess();
            return dataObj.ValidUser(userInfoObj);
        }
        public bool ChangeUserPassword(UserInformation userInfoObj)
        {
            if(userInfoObj.Password == userInfoObj.ConfirmPassword)
            {
                DataFactory factoryObj = new DataFactory();
                IDataAccess dataObj = factoryObj.GetDataAccess();
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

