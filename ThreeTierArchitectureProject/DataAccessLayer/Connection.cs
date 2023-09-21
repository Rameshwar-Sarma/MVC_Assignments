using System.Data.SqlClient;

namespace DataAccessLayer
{
    public static class Connection
    {
        public static SqlConnection SQLConObj = new SqlConnection("Data Source=192.168.0.30;Initial Catalog=empid250;Persist Security Info=True;User ID=User5;Password=CDev005#8");
    }
}