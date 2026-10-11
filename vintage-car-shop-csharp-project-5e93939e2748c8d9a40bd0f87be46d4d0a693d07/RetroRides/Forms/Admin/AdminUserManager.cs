using ComponentFactory.Krypton.Toolkit;
using RetroRides.BLL.Admin;
using RetroRides.Data;
using RetroRides.Utilities;
using System;
using System.Data;
using System.Windows.Forms;

namespace RetroRides.Forms.Admin
{
    public partial class AdminUserManager : KryptonForm
    {
        private readonly UserService _userService;
        private string _currentAdminUsername; // Store the current logged-in admin's username

        public AdminUserManager()
        {
            InitializeComponent();

            // Initialize UserService
            _userService = new UserService(new DatabaseConnection());

            // Set the logged-in admin's username (this should be passed from the login form)
            _currentAdminUsername = FormManager.GetLoggedInUsername();

            ConfigureListView(); // Configure the ListView columns
            LoadUsers();         // Load the users from the database into the ListView


            try
            {
                // Apply rounded corners
                FormDesign.ApplyRoundedCorners(this, 7);
                // Make form draggable
                FormDesign.MakeFormDraggable(this, top_panel);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error applying rounded corners: " + ex.Message);
            }

        }








        // Configure ListView with columns
        //--------------------------------------------------------------------------
        private void ConfigureListView()
        {
            usersListView.View = View.Details;
            usersListView.FullRowSelect = true;
            usersListView.Columns.Clear();
            usersListView.Columns.Add("Username", 100, HorizontalAlignment.Left);
            usersListView.Columns.Add("Name", 100, HorizontalAlignment.Left);
            usersListView.Columns.Add("Address", 200, HorizontalAlignment.Left);
            usersListView.Columns.Add("Phone", 120, HorizontalAlignment.Left);
        }
        //--------------------------------------------------------------------------




        // Load users into the ListView from the database
        //--------------------------------------------------------------------------
        private void LoadUsers()
        {
            DataTable usersTable = _userService.LoadUsers();


            // Clear the ListView before adding new data
            usersListView.Items.Clear();

            // Populate ListView with users from the DataTable
            foreach (DataRow row in usersTable.Rows)
            {
                ListViewItem item = new ListViewItem(row["username"].ToString()); // Username
                item.SubItems.Add(row["name"].ToString());   // Name
                item.SubItems.Add(row["address"].ToString());  // Address
                item.SubItems.Add(row["phone"].ToString()); // phone

                usersListView.Items.Add(item);
            }
        }
        //--------------------------------------------------------------------------













        // BUTTON FUNCTIONS:
        //--------------------------------------------------------------------------

        // promotes or demotes a user to admin or user.
        private void promoteButton_Click(object sender, EventArgs e)
        {
            if (usersListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a user to promote.");
                return;
            }

            // Get the selected user's username
            string selectedUsername = usersListView.SelectedItems[0].Text;

            // Prompt for confirmation
            DialogResult result = MessageBox.Show($"Are you sure you want to promote {selectedUsername} to an Admin?",
                "Confirm Promotion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No) return;

            // Use the UserService to promote the selected user
            bool success = _userService.PromoteUserToAdmin(selectedUsername);

            if (success)
            {
                MessageBox.Show($"{selectedUsername} has been promoted to Admin.");
                LoadUsers();  // Reload the list to reflect the promotion
            }
            else
            {
                MessageBox.Show("Failed to promote the user.");
            }
        }






        // Deletes an user.

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (usersListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a user to delete.");
                return;
            }

            // Get the selected user's username
            string selectedUsername = usersListView.SelectedItems[0].Text;

            // Prompt for confirmation before deletion
            DialogResult result = MessageBox.Show($"Are you sure you want to delete {selectedUsername}?",
                "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.No) return;

            // Use the UserService to delete the selected user
            bool success = _userService.DeleteUser(selectedUsername);

            if (success)
            {
                MessageBox.Show($"{selectedUsername} has been deleted.");
                LoadUsers();  // Reload the list to reflect the deletion
            }
            else
            {
                MessageBox.Show("Failed to delete the user.");
            }
        }



        // General method to handle navigation to different forms
        //-------------------------------------------------------
        private void NavigateToForm(KryptonForm targetForm)
        {
            targetForm.StartPosition = FormStartPosition.Manual;
            targetForm.Location = this.Location;
            FormDesign.FadeTransition(this, targetForm);
        }
        //--------------------------------------------------------

        // Button click event handlers for navigation
        private void car_info_Click(object sender, EventArgs e)
        {
            NavigateToForm(FormManager.GetCarForm());
        }

        private void Client_info_Click(object sender, EventArgs e)
        {
            NavigateToForm(FormManager.GetClientForm());
        }

        private void dash_btn_Click(object sender, EventArgs e)
        {
            NavigateToForm(FormManager.GetDashForm());
        }

        private void admin_btn_Click(object sender, EventArgs e)
        {
            NavigateToForm(FormManager.GetAdminForm());
        }

        private void min_btn_Click(object sender, EventArgs e)
        {
            // Minimize the form
            this.WindowState = FormWindowState.Minimized;
        }

        private void cross_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void viewCreditCardButton_Click(object sender, EventArgs e)
        {
            if (usersListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a user to view their payment details.");
                return;
            }

            // Get the selected user's UserId
            string selectedUsername = usersListView.SelectedItems[0].Text;
            int userId = _userService.GetUserIdByUsername(selectedUsername);

            // Open the UserPaymentInfoForm with the selected user's payments
            UserCardInfoForm paymentInfoForm = new UserCardInfoForm(userId);
            paymentInfoForm.StartPosition = FormStartPosition.CenterParent;
            paymentInfoForm.ShowDialog();  // Open as modal dialog
        }

        private void viewPaymentButton_Click(object sender, EventArgs e)
        {
            if (usersListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a user to view their payment details.");
                return;
            }

            // Get the selected user's UserId
            string selectedUsername = usersListView.SelectedItems[0].Text;
            int userId = _userService.GetUserIdByUsername(selectedUsername);

            // Open the UserPaymentInfoForm with the selected user's payments
            Payments pay = new Payments(userId);
            pay.StartPosition = FormStartPosition.CenterParent;
            pay.ShowDialog();  // Open as modal dialog
        }
    }

    //--------------------------------------------------------------------------

}
