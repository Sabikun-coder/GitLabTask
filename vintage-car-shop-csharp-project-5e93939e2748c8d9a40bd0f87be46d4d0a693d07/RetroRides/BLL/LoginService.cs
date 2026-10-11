using RetroRides.Data;
using System;
using System.Data.SqlClient;

namespace RetroRides.BLL
{
    public class LoginService
    {
        private readonly DatabaseConnection _dbConnection;

        public LoginService(DatabaseConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public (bool isSuccess, bool isAdmin, bool isSuperAdmin) ValidateLogin(string username, string password)
        {
            string query = "SELECT IsAdmin, IsSuperAdmin FROM ussers WHERE username = @username AND password = @password";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@username", username.Trim()),
                new SqlParameter("@password", password.Trim()) 
            };

            using (SqlConnection conn = _dbConnection.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddRange(parameters);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Retrieve IsAdmin and IsSuperAdmin flags
                            bool isAdmin = Convert.ToBoolean(reader["IsAdmin"]);
                            bool isSuperAdmin = Convert.ToBoolean(reader["IsSuperAdmin"]);
                            return (true, isAdmin, isSuperAdmin);
                        }
                        else
                        {
                            return (false, false, false);  // Login failed
                        }
                    }
                }
            }
        }
    }
}
