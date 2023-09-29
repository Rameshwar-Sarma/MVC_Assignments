using System;
using System.Data;
using System.Data.SqlClient;
using DataModel;


namespace DataAccessLayer
{
    internal class DataAccess : IDataAccess
    {
        /// <summary>
        /// Adding a new user
        /// </summary>
        /// <param name="UserName"></param>
        /// <param name="Password"></param>
        public bool AddNewUser(UserInformation userInfoObj)
        {
            ExecuteQuery($"Insert into Users values('{userInfoObj.UserName}','{userInfoObj.Password}','{userInfoObj.Email}');");
            return true;
        }
        /// <summary>
        /// Finding whether user exists or not
        /// </summary>
        /// <param name="UserName"></param>
        /// <returns></returns>
        public bool HasUser(UserInformation userInfoObj)
        {
            DataTable dt = ExecuteQuery($"Select * from Users where username = '{userInfoObj.UserName}';");
            if (dt.Rows.Count == 1)
            {
                return true;
            }
            return false;
        }
        public bool EmailRegistered(UserInformation userInfoObj)
        {
            DataTable dt = ExecuteQuery($"Select * from Users where email = '{userInfoObj.Email}';");
            if (dt.Rows.Count == 1)
            {
                return true;
            }
            return false;
        }
        public bool ValidUser(UserInformation userInfoObj)
        {
            DataTable dt = ExecuteQuery($"Select * from Users " +
                $"where username ='{userInfoObj.UserName}' and password = '{userInfoObj.Password}'");
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
        public bool NewPassword(UserInformation userInfoObj)
        {
            ExecuteQuery($"update Users set password = '{userInfoObj.Password}'" +
                $"where username = '{userInfoObj.UserName}';");
            return true;
        }
        public DataTable ExecuteQuery(string query)
        {
            //string connection = System.Configuration.ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;
            SqlConnection sqlConnectionObj = new SqlConnection("Data Source=COGNINE-L41\\SQLEXPRESS;Initial Catalog=Locale;Integrated Security=True");
            sqlConnectionObj.Open();

            DataTable tableObj = new DataTable();
            SqlCommand cmdObj = new SqlCommand(query, sqlConnectionObj);
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


