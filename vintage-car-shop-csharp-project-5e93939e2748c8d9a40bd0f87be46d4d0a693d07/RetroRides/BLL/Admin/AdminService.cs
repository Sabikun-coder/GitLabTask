using RetroRides.Data;
using System.Data;
using System.Data.SqlClient;

namespace RetroRides.BLL.Admin
{
    public class AdminService
    {
        private readonly DatabaseConnection _dbConnection;

        public AdminService(DatabaseConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        // Load all admins and superadmins from the database
        public DataTable LoadAdmins()
        {
            string query = "SELECT username, name, address, phone, IsAdmin, IsSuperAdmin FROM ussers WHERE IsAdmin = 1 OR IsSuperAdmin = 1";
            DataTable usersTable = new DataTable();

            using (SqlConnection conn = _dbConnection.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(usersTable);
                    }
                }
            }

            return usersTable;
        }

        // Demote an admin to a regular user
        public bool DemoteAdmin(string username)
        {
            string query = "UPDATE ussers SET IsAdmin = 0 WHERE username = @username";
            SqlParameter[] parameters = {
                new SqlParameter("@username", username)
            };

            return _dbConnection.ExecuteNonQuery(query, parameters) > 0;
        }

        // Delete an admin from the database
        public bool DeleteAdmin(string username)
        {
            string query = "DELETE FROM ussers WHERE username = @username";
            SqlParameter[] parameters = {
                new SqlParameter("@username", username)
            };

            return _dbConnection.ExecuteNonQuery(query, parameters) > 0;
        }
    }
}
