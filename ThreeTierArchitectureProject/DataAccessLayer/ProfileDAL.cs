using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class ProfileDAL
    {
        /// <summary>
        /// Adding a new user
        /// </summary>
        /// <param name="UserName"></param>
        /// <param name="Password"></param>
        public void AddNewUser(String UserName, String Password)
        {
            ExecuteQuery($"Insert into Users values('{UserName}','{Password}');");
        }
        /// <summary>
        /// Finding whether user exists or not
        /// </summary>
        /// <param name="UserName"></param>
        /// <returns></returns>
        public bool HasUser(String UserName)
        {
            DataTable dt = ExecuteQuery($" Select * from Users where username = '{UserName}';");
            if (dt.Rows.Count == 1)
            {
                return true;
            }
            return false;
        }
        public bool hasUser(String UserName, String Password)
        {
            DataTable dt = ExecuteQuery($"Select * from Users " +
                $"where username ='{UserName}' and password = '{Password}'");
            if (dt.Rows.Count == 1)
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// Updating a user's password with new Password.
        /// </summary>
        /// <param name="UserName"></param>
        /// <param name="Password"></param>
        public void NewPassword(String UserName, String Password)
        {
            ExecuteQuery($"update Users set password = '{Password}'" +
                $"where username = '{UserName}';");
        }
        public DataTable ExecuteQuery(String query)
        {
            DataTable tableObj = new DataTable();
            if (ConnectionState.Closed == Connection.SQLConObj.State)
            {
                Connection.SQLConObj.Open();
            }
            SqlCommand cmdObj = new SqlCommand(query, Connection.SQLConObj);
            try
            {
                SqlDataReader readObj = cmdObj.ExecuteReader();
                tableObj.Load(readObj);
                return tableObj;
            }
            catch (Exception ex)
            {
                throw;
            }

        }

    }
}

