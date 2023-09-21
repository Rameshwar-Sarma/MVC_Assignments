
namespace PresentationLayer
{
    /// <summary>
    /// This is a Three tier Architecure Project to login to a portal.
    /// </summary>
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=========================================================");
            Console.WriteLine("-----------------Welcome to the Portal-------------------");
            int response = 0;
            do
            {
                do
                {
                    Console.WriteLine();
                    Console.WriteLine(" 1.Register   2.Login  3.Exit");
                    Console.Write("Please Select valid Option :");
                    response = Convert.ToInt32(Console.ReadLine());
                } while (response < 1 && response > 3);

                Console.WriteLine();
                UserInterface uiObj = new UserInterface();

                if (response == 1)
                {
                    Console.Write("Please Enter new UserName :");
                    String UserName = Console.ReadLine();

                    uiObj.Register(UserName);
                }
                else if (response ==2)
                {
                    Console.Write("Please Enter your UserName :");
                    String UserName = Console.ReadLine();

                    uiObj.Login(UserName);
                }
            } while (response !=3);
        }
    }
}