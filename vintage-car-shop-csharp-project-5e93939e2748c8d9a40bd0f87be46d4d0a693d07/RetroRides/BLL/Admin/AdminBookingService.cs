using RetroRides.Data;
using System.Data;
using System.Data.SqlClient;

namespace RetroRides.BLL.Admin
{
    public class AdminBookingService
    {
        private readonly DatabaseConnection _dbConnection;

        public AdminBookingService(DatabaseConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        // Load all bookings along with user and car details
        public DataTable LoadBookings()
        {
            string query = @"SELECT 
                                b.BookingId,
                                u.username,
                                u.name,
                                u.address,
                                u.phone,
                                c.ModelName,
                                b.BookingDate,         
                                b.ReservationDate       
                             FROM Bookings b
                             JOIN ussers u ON b.UserId = u.Id
                             JOIN Cars c ON b.CarId = c.CarId";

            DataTable bookingsTable = new DataTable();

            using (SqlConnection conn = _dbConnection.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(bookingsTable);
                    }
                }
            }

            return bookingsTable;
        }

        // Delete a booking by BookingId
        public bool DeleteBooking(int bookingId)
        {
            string query = "DELETE FROM Bookings WHERE BookingId = @bookingId";
            SqlParameter[] parameters = {
                new SqlParameter("@bookingId", bookingId)
            };

            int rowsAffected = _dbConnection.ExecuteNonQuery(query, parameters);
            return rowsAffected > 0;
        }
    }
}
