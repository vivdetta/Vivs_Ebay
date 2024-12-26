using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vivs_Ebay.Repository
{
    public class DataContext
    {
        public static string GetConnectionString()
        {
            return
                "Data Source=localhost;Initial Catalog=VivsEbay;Integrated Security=SSPI;TrustServerCertificate=True;";
        }

        private string _connString = DataContext.GetConnectionString();

        // General-purpose method to execute a SQL SELECT query and return the result as a DataTable
        public DataTable ExecuteCommandReturnTable(string sql, List<SqlParameter> parameters)
        {
            // Create and open a new SQL connection using the connection string
            using (SqlConnection conn = new SqlConnection(_connString))
            {
                conn.Open(); 

                // Initialize the SQL command with the provided SQL query and connection
                SqlCommand cmd = new SqlCommand(sql, conn);

                // If parameters are provided, add each parameter to the SQL command
                if (parameters != null)
                {
                    foreach (SqlParameter p in parameters)
                    {
                        cmd.Parameters.Add(p);
                    }
                }

                // DataTable to hold the result of the query
                DataTable data = new DataTable();

                // Use SqlDataAdapter to execute the command and fill the DataTable with the result set
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    adapter.Fill(data); // Executes the query and populates 'data' with the results
                }

                // Return the populated DataTable back to the caller
                return data;
            }
        }

        // General-purpose method to execute a SQL SELECT query that does not return any value
        public void ExecuteCommandNoReturnValue(string sql, List<SqlParameter> parameters)
        {
            using (SqlConnection conn = new SqlConnection(_connString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    
                    cmd.Parameters.AddRange(parameters.ToArray());
                    cmd.ExecuteNonQuery(); 
                }
            }
        }


        public int GetUserIdByUsername(string username)
        {
            string sql = "SELECT ID FROM tblUser WHERE Username = @username";
            using (SqlConnection conn = new SqlConnection(_connString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@username", username);
                return (int)cmd.ExecuteScalar();
            }
        }

    }
}
