using DataModel;

namespace DataAccessLayer
{
    public interface IDataAccess
    {
        bool AddNewUser(UserInformation userInfoObj);
        bool HasUser(UserInformation userInfoObj);
        bool ValidUser(UserInformation userInfoObj);
        bool NewPassword(UserInformation userInfoObj);
        bool EmailRegistered(UserInformation userInfoObj);
    }
}
