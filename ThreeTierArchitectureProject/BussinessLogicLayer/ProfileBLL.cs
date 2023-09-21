using DataAccessLayer;

namespace BussinessLogic
{
    public class ProfileBLL
    {
        public void NewUser(String UserName, String Password)
        {
            ProfileDAL dalObj = new ProfileDAL();
            dalObj.AddNewUser(UserName, Password);
            
        }
        public bool ExistUser(String Username)
        {
            ProfileDAL dalObj = new ProfileDAL();
            return dalObj.HasUser(Username);
        }
        public bool LoginUser(String UserName, String Password)
        {
            ProfileDAL dalObj = new ProfileDAL();
            return dalObj.hasUser(UserName, Password);
        }
        public void ChangeUserPassword(String UserName, String Password)
        {
            ProfileDAL dalObj = new ProfileDAL();
            dalObj.NewPassword(UserName, Password);

        }
    }
}