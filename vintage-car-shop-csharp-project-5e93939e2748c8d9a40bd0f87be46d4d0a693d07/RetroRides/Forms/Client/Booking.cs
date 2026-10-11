using ComponentFactory.Krypton.Toolkit;
using RetroRides.BLL.Client;
using RetroRides.Data;
using RetroRides.Utilities;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace RetroRides.Forms.Client
{
    public partial class Booking : KryptonForm
    {
        // Service for handling booking-related operations
        private readonly ClientBookingService _bookingService;

        // Store the current user's details (username and ID)
        private readonly string _currentUsername;
        private readonly int _currentUserId;

        public Booking()
        {
            InitializeComponent();

            // Initialize the booking service with a new database connection
            _bookingService = new ClientBookingService(new DatabaseConnection());

            // Retrieve the logged-in username and user ID
            _currentUsername = FormManager.GetLoggedInUsername();
            _currentUserId = _bookingService.GetCurrentUserId(_currentUsername);

            // Set the minimum date for reservation to today's date
            reservationDatePicker.MinDate = DateTime.Today;

            // Load available car models into the ComboBox
            _bookingService.LoadCarModels(CarComboBox);

            // Configure the list view for displaying bookings
            ConfigureListView();

            // Load the user's past bookings
            LoadPastBookings();

            // Apply form design (rounded corners, draggable panel)
            ApplyFormDesign();
        }


        //--------------------------------------------------------------------------------------------
        private void ApplyFormDesign()
        {
            try
            {
                // Apply rounded corners and make the form draggable
                FormDesign.ApplyRoundedCorners(this, 7);
                FormDesign.MakeFormDraggable(this, panel1);
            }
            catch (Exception ex)
            {
                // Handle any errors that occur when applying the design
                ShowErrorMessage("Error applying rounded corners: ", ex);
            }
        }
        //--------------------------------------------------------------------------------------------



        // Triggered when a car model is selected from the ComboBox
        //--------------------------------------------------------------------------------------------
        private void CarComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            var selectedCar = (CarModel)CarComboBox.SelectedItem;
            // Load details of the selected car
            LoadCarDetails(selectedCar.CarId);
        }
        //--------------------------------------------------------------------------------------------




        // Fetches car details from the database and updates the UI with the car information
        //--------------------------------------------------------------------------------------------
        private void LoadCarDetails(int carId)
        {
            _bookingService.LoadCarDetails(carId, reader =>
            {
                // Update labels with car details from the database reader
                carNameLabel.Text = reader["ModelName"].ToString();
                yearLabel.Text = reader["YearOfManufacture"].ToString();
                topSpeedLabel.Text = reader["TopSpeed"] + " km/h";
                maxPowerLabel.Text = reader["MaxPower"] + " HP";
                priceLabel.Text = reader["Price"] + " BDT";
                descriptionLabel.Text = reader["Description"].ToString();

                // Load the car image if the file exists, otherwise set the image to null
                carPictureBox.Image = LoadCarImage(reader["ImagePath"].ToString());
            });
        }
        //--------------------------------------------------------------------------------------------


        // Helper function to load car image from a file path
        //--------------------------------------------------------------------------------------------
        private Image LoadCarImage(string imagePath)
        {
            return File.Exists(imagePath) ? Image.FromFile(imagePath) : null;
        }
        //--------------------------------------------------------------------------------------------



        // Configures the ListView to display bookings with columns
        //--------------------------------------------------------------------------------------------
        private void ConfigureListView()
        {
            bookingsListView.View = View.Details; // Show details view
            bookingsListView.FullRowSelect = true; // Allow selection of the entire row
            bookingsListView.GridLines = true; // Show grid lines for better visibility

            // Add columns to display booking information
            bookingsListView.Columns.Add("Booking ID", 100, HorizontalAlignment.Left);
            bookingsListView.Columns.Add("Car Model", 150, HorizontalAlignment.Left);
            bookingsListView.Columns.Add("Booking Date", 120, HorizontalAlignment.Left);
            bookingsListView.Columns.Add("Reservation Date", 150, HorizontalAlignment.Left);
        }
        //--------------------------------------------------------------------------------------------




        // Loads the past bookings of the current user into the ListView
        //--------------------------------------------------------------------------------------------
        private void LoadPastBookings()
        {
            var pastBookings = _bookingService.GetPastBookings(_currentUserId);

            bookingsListView.Items.Clear(); // Clear any previous items

            // Show a message if no bookings are found
            if (pastBookings.Rows.Count == 0)
            {
                ShowInfoMessage("No past bookings found.");
                return;
            }

            // Add each booking to the ListView
            foreach (DataRow row in pastBookings.Rows)
            {
                var item = new ListViewItem(row["BookingId"].ToString());
                item.SubItems.Add(row["ModelName"].ToString());
                item.SubItems.Add(Convert.ToDateTime(row["BookingDate"]).ToString("yyyy-MM-dd"));
                item.SubItems.Add(Convert.ToDateTime(row["ReservationDate"]).ToString("yyyy-MM-dd"));

                bookingsListView.Items.Add(item);
            }
        }

        //--------------------------------------------------------------------------------------------




        // Triggered when the 'Book' button is clicked
        //--------------------------------------------------------------------------------------------
        private void book_btn_Click(object sender, EventArgs e)
        {
            if (CarComboBox.SelectedItem == null)
            {
                ShowInfoMessage("Please select a car model.");
                return;
            }

            var selectedCar = (CarModel)CarComboBox.SelectedItem;
            var reservationDate = reservationDatePicker.Value.Date;

            // Validate reservation date (cannot be in the past)
            if (!IsReservationDateValid(reservationDate)) return;

            // Load saved credit card information
            var savedCardInfo = _bookingService.GetSavedCreditCardInfo(_currentUserId);

            // Display the credit card form with the saved information
            using (var creditCardForm = new CreditCardForm(
                savedCardInfo.cardNumber,
                savedCardInfo.expiryDate,
                savedCardInfo.cvv,
                savedCardInfo.cardName))
            {
                // If the user provides valid credit card info and submits
                if (creditCardForm.ShowDialog() == DialogResult.OK)
                {
                    // Process the booking and reload past bookings
                    ProcessBooking(selectedCar, reservationDate, creditCardForm);
                    LoadPastBookings();
                }
                else
                {
                    ShowWarningMessage("Booking canceled, payment details not provided.");
                }
            }
        }
        //--------------------------------------------------------------------------------------------



        // Validates the reservation date (must be today or a future date)
        //--------------------------------------------------------------------------------------------
        private bool IsReservationDateValid(DateTime reservationDate)
        {
            if (reservationDate < DateTime.Today)
            {
                ShowInfoMessage("You cannot select a past date for the reservation.");
                return false;
            }
            return true;
        }
        //--------------------------------------------------------------------------------------------



        // Processes the booking by saving payment details and generating a receipt
        //--------------------------------------------------------------------------------------------
        private void ProcessBooking(CarModel selectedCar, DateTime reservationDate, CreditCardForm creditCardForm)
        {
            // Save the booking and payment information
            int bookingId = _bookingService.BookCarWithPayment(
                _currentUserId,
                selectedCar.CarId,
                reservationDate,
                creditCardForm.CardNumber,
                creditCardForm.ExpiryDate,
                creditCardForm.CVV,
                creditCardForm.CardName,
                creditCardForm.RememberCard);

            // Get the booking details for the receipt
            var bookingDetails = _bookingService.GetBookingDetails(_currentUserId, selectedCar.CarId);

            // Generate a PDF receipt for the booking
            _bookingService.GeneratePdfReceipt(bookingDetails.bookingId, bookingDetails.username, bookingDetails.carModel, creditCardForm.CardName, creditCardForm.CardNumber, creditCardForm.ExpiryDate, reservationDate);

            // Notify the user that the booking was successful
            ShowInfoMessage($"Booking successfully applied for {reservationDate:yyyy-MM-dd}!");
        }
        //--------------------------------------------------------------------------------------------


        //--------------------------------------------------------------------------------------------

        // Displays an error message
        private void ShowErrorMessage(string message, Exception ex)
        {
            MessageBox.Show($"{message} {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        // Displays an informational message
        private void ShowInfoMessage(string message)
        {
            MessageBox.Show(message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Displays a warning message
        private void ShowWarningMessage(string message)
        {
            MessageBox.Show(message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        //--------------------------------------------------------------------------------------------





        // Navigates back to the main form
        //--------------------------------------------------------------------------------------------
        private void GoBackToMainForm()
        {
            MainForm mainForm = FormManager.GetDashboardForm();
            mainForm.StartPosition = FormStartPosition.Manual;
            mainForm.Location = this.Location;
            FormDesign.FadeTransition(this, mainForm);
            //mainForm.Show();
            //this.Hide();
        }
        //--------------------------------------------------------------------------------------------



        // Event handlers for navigating back to the main form
        private void home_btn_Click(object sender, EventArgs e) => GoBackToMainForm();
        private void goback_btn_Click(object sender, EventArgs e) => GoBackToMainForm();

        // Cancels the current booking
        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Opacity = 0.5;
            using (var confirmLogout = new ConfirmLogout())
            {
                if (confirmLogout.ShowDialog() == DialogResult.OK)
                {
                    Application.Exit();
                }
                this.Opacity = 1.0;
            }
        }

        // Minimizes the current window
        private void min_btn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // Opens the settings form
        private void settings_btn_Click(object sender, EventArgs e)
        {
            ShowSettingsForm();
        }

        // Helper function to show the settings form
        private void ShowSettingsForm()
        {
            Settings settings = FormManager.GetSettingsForm();
            settings.StartPosition = FormStartPosition.Manual;
            settings.Location = this.Location;
            FormDesign.FadeTransition(this, settings);
            //settings.Show();
            //this.Hide();
        }

        // Cancels a booking
        private void cancelBooking_btn_Click(object sender, EventArgs e)
        {
            if (bookingsListView.SelectedItems.Count == 0)
            {
                ShowInfoMessage("Please select a booking to cancel.");
                return;
            }

            int bookingId = int.Parse(bookingsListView.SelectedItems[0].SubItems[0].Text);

            // Confirm the cancellation of the booking
            if (MessageBox.Show("Are you sure you want to cancel this booking?", "Confirm Cancellation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                CancelBooking(bookingId);
            }
        }

        // Cancels the booking and reloads the ListView
        private void CancelBooking(int bookingId)
        {
            try
            {
                _bookingService.CancelBooking(bookingId);
                ShowInfoMessage("Booking canceled successfully.");
                RefreshBookingListView();
            }
            catch (Exception ex)
            {
                ShowErrorMessage("Error canceling the booking:", ex);
            }
        }

        // Refreshes the ListView after a booking change (e.g., cancellation)
        private void RefreshBookingListView()
        {
            bookingsListView.Items.Clear();
            LoadPastBookings();
        }
    }
}
