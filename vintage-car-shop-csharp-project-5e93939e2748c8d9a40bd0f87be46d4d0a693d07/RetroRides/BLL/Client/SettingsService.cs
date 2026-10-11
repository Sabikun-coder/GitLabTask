using RetroRides.Data;
using System;
using System.Data.SqlClient;

namespace RetroRides.BLL.Client
{
    public class SettingsService
    {
        private readonly DatabaseConnection _dbConnection;

        public SettingsService(DatabaseConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        // Load user information by username
        public (string name, string address, string phone, string username) LoadUserInfo(string username)
        {
            string query = "SELECT name, address, phone, username FROM ussers WHERE username = @username";
            SqlParameter[] parameters = { new SqlParameter("@username", username) };

            using (SqlConnection conn = _dbConnection.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddRange(parameters);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return (
                                reader["name"]?.ToString(),
                                reader["address"]?.ToString(),
                                reader["phone"]?.ToString(),
                                reader["username"].ToString()
                            );
                        }
                    }
                }
            }

            return (null, null, null, null);  // Return default if not found
        }

        // Validate if the current credentials (username and password) are correct
        public bool IsValidCurrentCredentials(string username, string password)
        {
            string query = "SELECT COUNT(*) FROM ussers WHERE username = @username AND password = @password";
            SqlParameter[] parameters = {
                new SqlParameter("@username", username),
                new SqlParameter("@password", password)
            };
            return _dbConnection.RecordExists(query, parameters);
        }

        // Check if a username already exists in the database
        public bool UsernameExists(string username)
        {
            string query = "SELECT COUNT(*) FROM ussers WHERE username = @username";
            SqlParameter[] parameters = { new SqlParameter("@username", username) };
            return _dbConnection.RecordExists(query, parameters);
        }

        // Update user details in the database
        public int UpdateUserDetails(string name, string address, string currentUsername, string newUsername, string newPassword, string phone)
        {
            string query = "UPDATE ussers SET name = @name, address = @address, phone = @phone, " +
                           "username = ISNULL(@newUsername, username), password = ISNULL(@newPassword, password) " +
                           "WHERE username = @currentUsername";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@name", name),
                new SqlParameter("@address", address),
                new SqlParameter("@phone", phone),
                new SqlParameter("@newUsername", (object)newUsername ?? DBNull.Value),
                new SqlParameter("@newPassword", (object)newPassword ?? DBNull.Value),
                new SqlParameter("@currentUsername", currentUsername)
            };

            return _dbConnection.ExecuteNonQuery(query, parameters);
        }
    }
}
