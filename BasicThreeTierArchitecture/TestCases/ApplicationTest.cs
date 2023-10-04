using BussinessLogicLayer;
using DataModel;

namespace TestCases
{
    [TestClass]
    public class ApplicationTest
    {
        [TestMethod]

        public void TestNewUserInput()
        {
            //Arrange
            BLLAuthentication bllObj = new BLLAuthentication();
            UserInformation userObj = new UserInformation();

            userObj.UserName = "RameshwaraSarma";
            userObj.Email = "rameshwara.yellepeddi@gmail.com";
            userObj.Password = "rameshwar24";
            userObj.ConfirmPassword = "rameshwar24";

            //Act
            bool actualValue = bllObj.RegisterAuthentication(userObj);

            //Assert
            Assert.AreEqual(false, actualValue);
        }

        [TestMethod]

        public void TestLogin()
        {
            //Arrange
            BLLValidation validObj = new BLLValidation();
            UserInformation userObj = new UserInformation();

            userObj.UserName = "RameshwaraSarma";
            userObj.Password = "rameshwar24";

            //Act
            bool actualValue = validObj.LoginUser(userObj);

            //Assert
            Assert.AreEqual(true, actualValue);
        }
        [TestMethod]

        public void TestUserExistance()
        {
            //Arrange
            BLLValidation validObj = new BLLValidation();
            UserInformation userObj = new UserInformation();

            userObj.UserName = "RameshwaraSarma";

            //Act
            bool actualValue = validObj.ExistUser(userObj);

            //Assert
            Assert.AreEqual(true, actualValue);
        }
        [TestMethod]
        public void TestPasswordChange()
        {
            //Arrange
            BLLValidation validObj = new BLLValidation();
            UserInformation userObj = new UserInformation();

            userObj.UserName = "RameshwaraSarma";
            userObj.Password = "rameshwar24";
            userObj.ConfirmPassword = "rameshwar24";

            //Act
            bool actualValue = validObj.ChangeUserPassword(userObj);

            //Assert
            Assert.AreEqual(true, actualValue);
        }
    }
}