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
        /// <param name="userInfoObj"></param>
        /// <returns></returns>
        public bool AddNewUser(UserInformation userInfoObj)
        {
            DataTable tableObj = ExecuteQuery($"Insert into Users values('{userInfoObj.UserName}','{userInfoObj.Password}','{userInfoObj.Email}');");
            if (tableObj == null)
            {
                return false;
            }
            return true;
        }
        /// <summary>
        /// Checking user existance
        /// </summary>
        /// <param name="userInfoObj"></param>
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
        /// <summary>
        /// Checking the registration of email.
        /// </summary>
        /// <param name="userInfoObj"></param>
        /// <returns></returns>
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
            DataTable tableObj = ExecuteQuery($"update Users set password = '{userInfoObj.Password}'" +
                $"where username = '{userInfoObj.UserName}';");
            if (tableObj == null)
            {
                return false;
            }
            return true;
        }
        public DataTable ExecuteQuery(string query)
        {
            //string connection = System.Configuration.ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;
            SqlConnection sqlConnectionObj = new SqlConnection("Data Source=COGNINE-L41\\SQLEXPRESS;Initial Catalog=Locale;Integrated Security=True");
            sqlConnectionObj.Open();

            DataTable dataObj = new DataTable();
            SqlCommand cmdObj = new SqlCommand(query, sqlConnectionObj);
            try
            {
                SqlDataReader readObj = cmdObj.ExecuteReader();
                dataObj.Load(readObj);
                return dataObj;
            }
            catch(Exception exception)
            {
                Console.WriteLine(exception);
            }
            return null;
        }
    }
}


