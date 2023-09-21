using BussinessLogic;

namespace PresentationLayer
{
    public class UserInterface
    {
        /// <summary>
        /// New Registrstion of a user
        /// </summary>
        /// <param name="UserName"></param>
        public void Register(String UserName)
        {
            ProfileBLL bllObj = new ProfileBLL();
            if (!bllObj.ExistUser(UserName))
            {
                Console.Write("Please enter new Password :");
                String Password = Console.ReadLine();
                bllObj.NewUser(UserName, Password);
                Console.WriteLine($"User {UserName} is registered Successfully to the portal !!!");
            }
            else
            {
                Console.WriteLine("User already exists, try with other username");
            }
        }
        /// <summary>
        /// user login with credentials
        /// </summary>
        /// <param name="UserName"></param>
        public void Login(String UserName)
        {
            ProfileBLL bllObj = new ProfileBLL();
            if (bllObj.ExistUser(UserName))
            {
                Console.Write("Please enter your Password :");
                String Password = Console.ReadLine();
                if (bllObj.LoginUser(UserName, Password))
                {
                    Console.WriteLine($"user {UserName} Successfully Logged in to the Portal !!!");
                }
                else
                {
                    Console.WriteLine("Incorrect Password !!!");
                    Console.WriteLine("Forgot Password ? \n press 'y' for 'yes' press 'n' to try with different password, press any other key to exit!!");
                    char isForget = Convert.ToChar(Console.ReadLine());

                    if (isForget == 'y' || isForget == 'Y')
                    {
                        ForgotPassword();
                    }
                    else if (isForget == 'n' || isForget == 'N')
                    {
                        Login(UserName);
                    }
                }
            }
            else
            {
                Console.WriteLine("Username not found !!!");
            }

        }
        /// <summary>
        /// Change of password, if in case user forgot password.
        /// </summary>
        public void ForgotPassword()
        {
            ProfileBLL bllObj = new ProfileBLL();
            Console.Write("Please Enter your UserName :");
            String UserName = Console.ReadLine();
            if (bllObj.ExistUser(UserName))
            {
                Console.Write("Please enter your new password : ");
                String Password = Console.ReadLine();

                bllObj.ChangeUserPassword(UserName, Password);
                Console.WriteLine("Password Cahnged Successfully !!!");
            }
            else
            {
                Console.WriteLine("User Not Found !!!");
            }
        }
    }
}

