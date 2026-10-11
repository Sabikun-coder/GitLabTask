using RetroRides.Data;
using System;
using System.Data.SqlClient;

namespace RetroRides.BLL
{
    public class RegistrationService
    {
        private readonly DatabaseConnection _dbConnection;

        public RegistrationService(DatabaseConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public bool IsUsernameTaken(string username)
        {
            string query = "SELECT COUNT(*) FROM ussers WHERE username = @username";
            SqlParameter[] parameters = { new SqlParameter("@username", username) };
            return _dbConnection.RecordExists(query, parameters);
        }

        public bool RegisterUser(string username, string password)
        {
            string query = "INSERT INTO ussers (username, password, date_register) VALUES (@username, @password, @dateReg)";
            SqlParameter[] parameters = {
                new SqlParameter("@username", username.Trim()),
                new SqlParameter("@password", password.Trim()),
                new SqlParameter("@dateReg", DateTime.Today)
            };
            int rowsAffected = _dbConnection.ExecuteNonQuery(query, parameters);
            return rowsAffected > 0;
        }
    }
}
