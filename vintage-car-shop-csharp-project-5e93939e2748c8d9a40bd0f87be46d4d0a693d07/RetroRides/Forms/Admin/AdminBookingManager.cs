using ComponentFactory.Krypton.Toolkit;
using RetroRides.BLL.Admin;
using RetroRides.Data;
using RetroRides.Utilities;
using System;
using System.Data;
using System.Windows.Forms;

namespace RetroRides.Forms.Admin
{
    public partial class AdminBookingManager : KryptonForm
    {
        private readonly AdminBookingService _bookingService;

        public AdminBookingManager()
        {
            InitializeComponent();

            // Initialize BookingService with database connection
            _bookingService = new AdminBookingService(new DatabaseConnection());

            // Setup the UI design and handle any exceptions
            ApplyFormDesign();

            // Setup the ListView columns once during initialization
            InitializeListViewColumns();

            // Load bookings into the ListView
            LoadBookings();
        }

        //---------------------------------------------------------------------------------------
        // Set up form design (rounded corners, draggable form)
        private void ApplyFormDesign()
        {
            try
            {
                FormDesign.ApplyRoundedCorners(this, 7);
                FormDesign.MakeFormDraggable(this, top_panel);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error applying rounded corners: " + ex.Message);
            }
        }

        //---------------------------------------------------------------------------------------
        // Initialize the ListView columns to prevent recreation on every LoadBookings call
        private void InitializeListViewColumns()
        {
            if (bookingsListView.Columns.Count == 0)
            {
                bookingsListView.Columns.Add("Booking ID", 50, HorizontalAlignment.Left);
                bookingsListView.Columns.Add("Username", 100, HorizontalAlignment.Left);
                bookingsListView.Columns.Add("Name", 100, HorizontalAlignment.Left);
                bookingsListView.Columns.Add("Address", 150, HorizontalAlignment.Left);
                bookingsListView.Columns.Add("Phone", 100, HorizontalAlignment.Left);
                bookingsListView.Columns.Add("Car Model", 180, HorizontalAlignment.Left);
                bookingsListView.Columns.Add("Booking Date", 130, HorizontalAlignment.Left);
                bookingsListView.Columns.Add("Reservation Date", 130, HorizontalAlignment.Left);
            }
        }

        //---------------------------------------------------------------------------------------
        // Method to load bookings from the database and display them in the ListView
        private void LoadBookings()
        {
            DataTable bookingsTable = _bookingService.LoadBookings();

            // Clear existing items in the ListView before adding new ones
            bookingsListView.Items.Clear();

            foreach (DataRow row in bookingsTable.Rows)
            {
                ListViewItem item = new ListViewItem(row["BookingId"].ToString());
                item.SubItems.Add(row["username"].ToString());
                item.SubItems.Add(row["name"].ToString());
                item.SubItems.Add(row["address"].ToString());
                item.SubItems.Add(row["phone"].ToString());
                item.SubItems.Add(row["ModelName"].ToString());
                item.SubItems.Add(Convert.ToDateTime(row["BookingDate"]).ToString("yyyy-MM-dd"));
                item.SubItems.Add(Convert.ToDateTime(row["ReservationDate"]).ToString("yyyy-MM-dd"));

                // Add the item to the ListView
                bookingsListView.Items.Add(item);
            }
        }

        //---------------------------------------------------------------------------------------
        // Delete the selected booking and refresh the ListView
        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (bookingsListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a booking to delete.");
                return;
            }

            int bookingId = int.Parse(bookingsListView.SelectedItems[0].Text);
            bool success = _bookingService.DeleteBooking(bookingId);

            if (success)
            {
                MessageBox.Show("Booking deleted successfully.");
                LoadBookings();  // Refresh the ListView after deletion
            }
            else
            {
                MessageBox.Show("Failed to delete the booking.");
            }
        }

        //---------------------------------------------------------------------------------------
        // Minimize the form
        private void min_btn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //---------------------------------------------------------------------------------------
        // Exit the application
        private void cross_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //---------------------------------------------------------------------------------------
        // Navigate to a different form based on button click
        private void NavigateToForm(KryptonForm targetForm)
        {
            targetForm.StartPosition = FormStartPosition.Manual;
            targetForm.Location = this.Location;
            FormDesign.FadeTransition(this, targetForm);
            //targetForm.Show();
            //this.Hide();
        }

        private void car_info_Click(object sender, EventArgs e)
        {
            NavigateToForm(FormManager.GetCarForm());
        }

        private void client_btn_Click(object sender, EventArgs e)
        {
            NavigateToForm(FormManager.GetUserForm());
        }

        private void dash_btn_Click(object sender, EventArgs e)
        {
            NavigateToForm(FormManager.GetDashForm());
        }

        private void admin_btn_Click(object sender, EventArgs e)
        {
            NavigateToForm(FormManager.GetAdminForm());
        }
    }
}
