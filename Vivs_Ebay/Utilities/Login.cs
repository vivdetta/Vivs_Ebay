using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vivs_Ebay.Repository;

namespace Vivs_Ebay.Utilities
{
    public class Login
    {
        private string _connString = DataContext.GetConnectionString();
        public bool AuthenticateUser(string username, string password)
        {
            

            using (SqlConnection conn = new SqlConnection(_connString))
            {
                conn.Open();
                string sql = "SELECT COUNT(1) FROM tblUser WHERE Username = @username AND Password = @password";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                int result = (int)cmd.ExecuteScalar();
                return result > 0; // Return true if user exists
            }
        }
        public bool RegisterUser(string username, string password)
        {
            using (SqlConnection conn = new SqlConnection(_connString))
            {
                conn.Open();
                string sql = "INSERT INTO tblUser (Username, Password) VALUES (@username, @password)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                try
                {
                    cmd.ExecuteNonQuery();
                    return true; 
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 2627) 
                    {
                        // Registration failed due to duplicate username
                        MessageBox.Show("Username already exists. Please choose a different username.");
                        return false; 
                    }
                    else
                    {
                        throw;
                    }
                }
            }
        }

    }
}
