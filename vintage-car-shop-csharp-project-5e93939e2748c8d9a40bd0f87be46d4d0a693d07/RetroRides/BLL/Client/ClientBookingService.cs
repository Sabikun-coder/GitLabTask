using ComponentFactory.Krypton.Toolkit;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using RetroRides.Data;
using RetroRides.Utilities;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows.Forms;


namespace RetroRides.BLL.Client
{
    public class ClientBookingService
    {
        private readonly DatabaseConnection _dbConnection;

        public ClientBookingService(DatabaseConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }


        // Fetch the user's ID from the database based on the current username
        //---------------------------------------------------------------------------------------

        public int GetCurrentUserId(string username)
        {
            string query = "SELECT Id FROM ussers WHERE username = @username";
            SqlParameter[] parameters = { new SqlParameter("@username", username) };
            return (int)_dbConnection.ExecuteScalar(query, parameters);
        }
        //---------------------------------------------------------------------------------------



        // gets the past bookings if any:
        //---------------------------------------------------------------------------------------
        public DataTable GetPastBookings(int userId)
        {
            string query = @"SELECT b.BookingId, c.ModelName, b.BookingDate, b.ReservationDate
                             FROM Bookings b
                             INNER JOIN Cars c ON b.CarId = c.CarId
                             WHERE b.UserId = @userId";
            SqlParameter[] parameters = { new SqlParameter("@userId", userId) };

            using (SqlConnection conn = _dbConnection.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddRange(parameters);
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable bookingsTable = new DataTable();
                        adapter.Fill(bookingsTable);
                        return bookingsTable;
                    }
                }
            }
        }

        //--------------------------------------------------------------------------------------






        // Load available car models into a ComboBox or DataGridView
        //---------------------------------------------------------------------------------------
        public void LoadCarModels(KryptonComboBox carComboBox)
        {
            string query = "SELECT CarId, ModelName, YearOfManufacture FROM Cars";

            using (SqlConnection conn = _dbConnection.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var carModel = new CarModel
                            {
                                CarId = Convert.ToInt32(reader["CarId"]),
                                ModelName = reader["ModelName"].ToString(),
                                YearOfManufacture = Convert.ToInt32(reader["YearOfManufacture"])
                            };

                            carComboBox.Items.Add(carModel);
                        }
                    }
                }
            }
        }
        //---------------------------------------------------------------------------------------




        // Load car details and display them in the form
        //---------------------------------------------------------------------------------------
        public void LoadCarDetails(int carId, Action<SqlDataReader> handleCarDetails)
        {
            string query = "SELECT * FROM Cars WHERE CarId = @carId";
            SqlParameter[] parameters = { new SqlParameter("@carId", carId) };

            using (SqlConnection conn = _dbConnection.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddRange(parameters);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            handleCarDetails(reader);
                        }
                    }
                }
            }
        }
        //---------------------------------------------------------------------------------------



        //Make sure that the IsUserInfoComplete method properly checks if the user has filled out all required fields:
        //-----------------------------------------------------------
        public bool IsUserInfoComplete(string username)
        {
            string query = "SELECT Name, Address, Phone FROM ussers WHERE username = @username";
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
                            string name = reader["Name"]?.ToString();
                            string address = reader["Address"]?.ToString();
                            string phone = reader["Phone"]?.ToString();

                            // Return true only if all required fields are filled
                            return !string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(address) && !string.IsNullOrEmpty(phone);
                        }
                    }
                }
            }

            return false;  // Return false if the user info is incomplete
        }
        //-----------------------------------------------------------





        //Booking
        //----------------------------------------------------------------------------------------------------
        public void CancelBooking(int bookingId)
        {
            string query = "DELETE FROM Bookings WHERE BookingId = @bookingId";
            SqlParameter[] parameters = { new SqlParameter("@bookingId", bookingId) };
            _dbConnection.ExecuteNonQuery(query, parameters);
        }



        public int BookCarWithPayment(int userId, int carId, DateTime reservationDate, string cardNumber, string expiryDate, string cvv, string cardName, bool rememberCard)
        {
            using (SqlConnection conn = _dbConnection.GetConnection())
            {
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    // Insert booking information
                    string bookingQuery = "INSERT INTO Bookings (UserId, CarId, ReservationDate) VALUES (@userId, @carId, @reservationDate); SELECT SCOPE_IDENTITY();";
                    SqlCommand bookingCmd = new SqlCommand(bookingQuery, conn, transaction);
                    bookingCmd.Parameters.AddWithValue("@userId", userId);
                    bookingCmd.Parameters.AddWithValue("@carId", carId);
                    bookingCmd.Parameters.AddWithValue("@reservationDate", reservationDate);
                    int bookingId = Convert.ToInt32(bookingCmd.ExecuteScalar());  // Get the inserted BookingId

                    // Insert payment information with RememberCard flag
                    string paymentQuery = @"INSERT INTO Payments 
                            (UserId, CardNumber, ExpiryDate, CVV, CardName, RememberCard) 
                            VALUES (@userId, @cardNumber, @expiryDate, @cvv, @cardName, @rememberCard)";
                    SqlCommand paymentCmd = new SqlCommand(paymentQuery, conn, transaction);
                    paymentCmd.Parameters.AddWithValue("@userId", userId);
                    paymentCmd.Parameters.AddWithValue("@cardNumber", cardNumber);
                    paymentCmd.Parameters.AddWithValue("@expiryDate", expiryDate);
                    paymentCmd.Parameters.AddWithValue("@cvv", cvv);
                    paymentCmd.Parameters.AddWithValue("@cardName", cardName);
                    paymentCmd.Parameters.AddWithValue("@rememberCard", rememberCard ? 1 : 0);  // Save 1 if RememberCard is checked, 0 otherwise
                    paymentCmd.ExecuteNonQuery();


                    // Save card details to SavedCard table if RememberCard is checked
                    if (rememberCard)
                    {
                        string saveCardQuery = @"INSERT INTO SavedCard (UserId, CardNumber, ExpiryDate, CVV, CardName, RememberCard) 
                                         VALUES (@userId, @cardNumber, @expiryDate, @cvv, @cardName, 1)";
                        SqlCommand saveCardCmd = new SqlCommand(saveCardQuery, conn, transaction);
                        saveCardCmd.Parameters.AddWithValue("@userId", userId);
                        saveCardCmd.Parameters.AddWithValue("@cardNumber", cardNumber);
                        saveCardCmd.Parameters.AddWithValue("@expiryDate", expiryDate);
                        saveCardCmd.Parameters.AddWithValue("@cvv", cvv);
                        saveCardCmd.Parameters.AddWithValue("@cardName", cardName);
                        saveCardCmd.ExecuteNonQuery();
                    }



                    // Commit transaction
                    transaction.Commit();

                    // Return the BookingId
                    return bookingId;
                }
                catch (Exception ex)
                {
                    // Rollback transaction in case of an error
                    transaction.Rollback();
                    throw new Exception("Error booking car and saving payment: " + ex.Message);
                }
            }
        }

        // Used to fetch the saved cards from the SavedCard table.
        //----------------------------------------------------------------------------------------------------
        public (string cardNumber, string expiryDate, string cvv, string cardName) GetSavedCreditCardInfo(int userId)
        {
            string query = @"SELECT TOP 1 CardNumber, ExpiryDate, CVV, CardName 
                     FROM SavedCard 
                     WHERE UserId = @userId AND RememberCard = 1 
                     ORDER BY PaymentId DESC"; // Fetch the most recently saved card

            SqlParameter[] parameters = { new SqlParameter("@userId", userId) };

            using (SqlConnection conn = _dbConnection.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddRange(parameters);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string cardNumber = reader["CardNumber"].ToString();
                            string expiryDate = reader["ExpiryDate"].ToString();
                            string cvv = reader["CVV"].ToString();
                            string cardName = reader["CardName"].ToString();

                            return (cardNumber, expiryDate, cvv, cardName);  // Return card details
                        }
                    }
                }
            }

            return (null, null, null, null);  // Return null if no card is saved
        }

        //----------------------------------------------------------------------------------------------------


        //Gets the booking details:
        //----------------------------------------------------------------------------------------------------
        public (int bookingId, string username, string carModel) GetBookingDetails(int userId, int carId)
        {
            string query = @"
        SELECT TOP 1 b.BookingId, u.username, c.ModelName
        FROM Bookings b
        INNER JOIN ussers u ON b.UserId = u.Id
        INNER JOIN Cars c ON b.CarId = c.CarId
        WHERE b.UserId = @userId AND b.CarId = @carId
        ORDER BY b.BookingId DESC"; // Fetch the latest booking

            SqlParameter[] parameters = {
        new SqlParameter("@userId", userId),
        new SqlParameter("@carId", carId)
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
                            int bookingId = Convert.ToInt32(reader["BookingId"]);
                            string username = reader["username"].ToString();
                            string carModel = reader["ModelName"].ToString();
                            return (bookingId, username, carModel);
                        }
                    }
                }
            }

            return (0, null, null); // Return default if no booking is found
        }




        // GENERATION OF THE RECEIPT
        //----------------------------------------------------------------------------------------------------
        public void GeneratePdfReceipt(int bookingId, string username, string carModel, string cardName, string cardNumber, string expiryDate, DateTime reservationDate)
        {
            try
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "PDF Files|*.pdf";
                    saveFileDialog.Title = "Save PDF Receipt";
                    saveFileDialog.FileName = "Receipt.pdf";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string filePath = saveFileDialog.FileName;

                        // Create a new PDF document
                        PdfDocument document = new PdfDocument();
                        document.Info.Title = "Credit Card Receipt";

                        // Create an empty page
                        PdfPage page = document.AddPage();
                        XGraphics gfx = XGraphics.FromPdfPage(page);

                        // Define fonts (updated for PDFsharp 6.1.0)
                        XFont titleFont = new XFont("Verdana", 24, XFontStyleEx.Bold);
                        XFont headerFont = new XFont("Verdana", 14, XFontStyleEx.Bold);
                        XFont detailFont = new XFont("Verdana", 12, XFontStyleEx.Regular);
                        XFont smallFont = new XFont("Verdana", 10, XFontStyleEx.Italic);

                        // Define colors
                        XBrush headerBrush = XBrushes.DarkBlue;
                        XBrush textBrush = XBrushes.Black;

                        // Draw a company logo (Replace 'logoPath' with actual logo path)
                        try
                        {
                            XImage logo = XImage.FromFile("logoPath.png"); // Ensure logo file is available
                            gfx.DrawImage(logo, 50, 20, 100, 50);
                        }
                        catch (Exception logoEx)
                        {
                            // Handle cases where the logo is not available
                            Console.WriteLine($"Logo not found: {logoEx.Message}");
                        }

                        // Draw the title (use page.Width.Point)
                        gfx.DrawString("RetroRides Booking-Receipt", titleFont, headerBrush, new XRect(0, 70, page.Width.Point, 40), XStringFormats.TopCenter);

                        // Draw a line separator (use page.Width.Point)
                        gfx.DrawLine(XPens.Black, 50, 120, page.Width.Point - 50, 120);

                        // Section Header: Booking Details
                        gfx.DrawString("Booking Details", headerFont, headerBrush, 50, 150);

                        // Booking Information
                        gfx.DrawString("Booking ID:", detailFont, textBrush, 50, 180);
                        gfx.DrawString(bookingId.ToString(), detailFont, textBrush, 200, 180);

                        gfx.DrawString("Username:", detailFont, textBrush, 50, 210);
                        gfx.DrawString(username, detailFont, textBrush, 200, 210);

                        gfx.DrawString("Car Model:", detailFont, textBrush, 50, 240);
                        gfx.DrawString(carModel, detailFont, textBrush, 200, 240);

                        // Add Reservation Date
                        gfx.DrawString("Reservation Date:", detailFont, textBrush, 50, 270);
                        gfx.DrawString(reservationDate.ToString("yyyy-MM-dd"), detailFont, textBrush, 200, 270);

                        // Draw a line separator (use page.Width.Point)
                        gfx.DrawLine(XPens.Gray, 50, 300, page.Width.Point - 50, 300);

                        // Section Header: Payment Details
                        gfx.DrawString("Payment Details", headerFont, headerBrush, 50, 330);

                        // Masked card number
                        string maskedCardNumber = cardNumber.Substring(0, 4) + " **** **** " + cardNumber.Substring(cardNumber.Length - 4);

                        // Card Information
                        gfx.DrawString("Cardholder Name:", detailFont, textBrush, 50, 360);
                        gfx.DrawString(cardName, detailFont, textBrush, 200, 360);

                        gfx.DrawString("Card Number:", detailFont, textBrush, 50, 390);
                        gfx.DrawString(maskedCardNumber, detailFont, textBrush, 200, 390);

                        gfx.DrawString("Expiry Date:", detailFont, textBrush, 50, 420);
                        gfx.DrawString(expiryDate, detailFont, textBrush, 200, 420);

                        // Draw a footer with a line (use page.Height.Point and page.Width.Point)
                        gfx.DrawLine(XPens.Black, 50, page.Height.Point - 80, page.Width.Point - 50, page.Height.Point - 80);
                        gfx.DrawString("Thank you for your booking! - RetroRides", smallFont, textBrush, new XRect(50, page.Height.Point - 60, page.Width.Point - 100, 30), XStringFormats.Center);

                        // Save the document
                        document.Save(filePath);
                        document.Close();

                        // Open the PDF after generating
                        Process.Start(new ProcessStartInfo(filePath) { UseShellExecute = true });
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to generate PDF receipt: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //----------------------------------------------------------------------------------------------------



    }


}
