using RetroRides.Data;
using System.Data;
using System.Data.SqlClient;

namespace RetroRides.BLL.Admin
{
    public class UserService
    {
        private readonly DatabaseConnection _dbConnection;

        public UserService(DatabaseConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        // Load all non-admin and non-superadmin users
        //----------------------------------------------------------------------------------------------------
        public DataTable LoadUsers()
        {
            string query = "SELECT username, name, address, phone FROM ussers WHERE IsAdmin = 0 AND IsSuperAdmin = 0";
            DataTable usersTable = new DataTable();

            using (SqlConnection conn = _dbConnection.GetConnection())
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                {
                    adapter.Fill(usersTable);
                }
            }

            return usersTable;
        }
        //----------------------------------------------------------------------------------------------------





        //Used to get the UserID belonging to a username:
        //----------------------------------------------------------------------------------------------------
        public int GetUserIdByUsername(string username)
        {
            string query = "SELECT Id FROM ussers WHERE username = @username";

            using (SqlConnection conn = _dbConnection.GetConnection())
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@username", username);
                return (int)cmd.ExecuteScalar();
            }
        }
        //----------------------------------------------------------------------------------------------------






        // Promote a user to an admin
        //----------------------------------------------------------------------------------------------------
        public bool PromoteUserToAdmin(string username)
        {
            string query = "UPDATE ussers SET IsAdmin = 1 WHERE username = @username";
            SqlParameter[] parameters = {
                new SqlParameter("@username", username)
            };

            return _dbConnection.ExecuteNonQuery(query, parameters) > 0;
        }
        //----------------------------------------------------------------------------------------------------





        // Delete a user from the database
        //----------------------------------------------------------------------------------------------------
        public bool DeleteUser(string username)
        {
            string query = "DELETE FROM ussers WHERE username = @username";
            SqlParameter[] parameters = {
                new SqlParameter("@username", username)
            };

            return _dbConnection.ExecuteNonQuery(query, parameters) > 0;
        }

        //----------------------------------------------------------------------------------------------------



        // Used to get the credit card info of a selected user.
        //----------------------------------------------------------------------------------------------------
        public DataTable GetPaymentInfo(int userId)
        {
            string query = "SELECT CardNumber, ExpiryDate, CardName, RememberCard FROM SavedCard WHERE UserId = @userId";

            using (SqlConnection conn = _dbConnection.GetConnection())
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@userId", userId);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable paymentTable = new DataTable();
                adapter.Fill(paymentTable);

                return paymentTable;
            }
        }
        //----------------------------------------------------------------------------------------------------


        // get the number of times user used a creditcard.
        //----------------------------------------------------------------------------------------------------
        public DataTable GetPayments(int userId)
        {
            string query = "SELECT CardNumber, ExpiryDate, CardName, RememberCard FROM Payments WHERE UserId = @userId";

            using (SqlConnection conn = _dbConnection.GetConnection())
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@userId", userId);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable paymentTable = new DataTable();
                adapter.Fill(paymentTable);

                return paymentTable;
            }
        }

        //----------------------------------------------------------------------------------------------------


        // Used to delete that credit card info from the user.
        //----------------------------------------------------------------------------------------------------
        public bool DeleteCardInfo(int userId, string lastFourDigits)
        {
            string query = "DELETE FROM Payments WHERE UserId = @userId AND RIGHT(CardNumber, 4) = @lastFourDigits";

            // Ensure connection is properly disposed of and not opened multiple times
            using (SqlConnection conn = _dbConnection.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@userId", userId);
                    cmd.Parameters.AddWithValue("@lastFourDigits", lastFourDigits);

                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }
        //----------------------------------------------------------------------------------------------------

    }

}

