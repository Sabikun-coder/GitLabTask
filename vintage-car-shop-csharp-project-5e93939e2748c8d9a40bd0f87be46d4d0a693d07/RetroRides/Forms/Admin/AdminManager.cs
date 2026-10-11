using ComponentFactory.Krypton.Toolkit;
using RetroRides.BLL.Admin;
using RetroRides.Data;
using RetroRides.Utilities;
using System;
using System.Data;
using System.Windows.Forms;

namespace RetroRides.Forms.Admin
{
    public partial class AdminManager : KryptonForm
    {
        private readonly AdminService _adminService;
        private string _currentAdminUsername; // Store the current logged-in admin's username

        public AdminManager()
        {
            InitializeComponent();

            // Initialize AdminService and fetch the current admin's username
            _adminService = new AdminService(new DatabaseConnection());
            _currentAdminUsername = FormManager.GetLoggedInUsername();

            ConfigureListView();  // Setup ListView
            LoadAdmins();         // Load admin data

            ApplyFormDesign();    // Apply form design
        }

        //---------------------------------------------------------------------------------------
        // Setup form design (rounded corners, draggable form)
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
        // Configure the ListView columns
        private void ConfigureListView()
        {
            usersListView.View = View.Details;
            usersListView.FullRowSelect = true;
            usersListView.Columns.Clear();
            usersListView.Columns.Add("Username", 100, HorizontalAlignment.Left);
            usersListView.Columns.Add("Name", 100, HorizontalAlignment.Left);
            usersListView.Columns.Add("Address", 200, HorizontalAlignment.Left);
            usersListView.Columns.Add("Phone", 100, HorizontalAlignment.Left);
            usersListView.Columns.Add("Admin Status", 100, HorizontalAlignment.Left);
            usersListView.Columns.Add("Super Admin", 100, HorizontalAlignment.Left);
        }

        //---------------------------------------------------------------------------------------
        // Load admin users into the ListView
        private void LoadAdmins()
        {
            DataTable usersTable = _adminService.LoadAdmins();
            usersListView.Items.Clear(); // Clear existing items

            foreach (DataRow row in usersTable.Rows)
            {
                ListViewItem item = new ListViewItem(row["username"].ToString());
                item.SubItems.Add(row["name"].ToString());
                item.SubItems.Add(row["address"].ToString());
                item.SubItems.Add(row["phone"].ToString());
                item.SubItems.Add(Convert.ToBoolean(row["IsAdmin"]) ? "Admin" : "User");
                item.SubItems.Add(Convert.ToBoolean(row["IsSuperAdmin"]) ? "Super Admin" : "");
                usersListView.Items.Add(item);
            }
        }

        //---------------------------------------------------------------------------------------
        // Demote the selected admin
        private void demoteButton_Click(object sender, EventArgs e)
        {
            if (!IsUserSelected()) return;

            string selectedUsername = GetSelectedUsername();
            if (PreventSelfAction(selectedUsername, "demote")) return;

            bool isSuperAdmin = IsSuperAdminSelected();
            if (isSuperAdmin)
            {
                MessageBox.Show("You cannot demote a Super Admin.");
                return;
            }

            // Attempt to demote the admin
            bool success = _adminService.DemoteAdmin(selectedUsername);
            HandleOperationResult(success, $"{selectedUsername} has been demoted to a regular user.", "Failed to demote the user.");
        }

        //---------------------------------------------------------------------------------------
        // Delete the selected admin
        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (!IsUserSelected()) return;

            string selectedUsername = GetSelectedUsername();
            if (PreventSelfAction(selectedUsername, "delete")) return;

            bool isSuperAdmin = IsSuperAdminSelected();
            if (isSuperAdmin)
            {
                MessageBox.Show("You cannot delete a Super Admin.");
                return;
            }

            // Confirm deletion
            if (MessageBox.Show($"Are you sure you want to delete {selectedUsername}?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                return;

            // Attempt to delete the admin
            bool success = _adminService.DeleteAdmin(selectedUsername);
            HandleOperationResult(success, $"{selectedUsername} has been deleted.", "Failed to delete the user.");
        }

        //---------------------------------------------------------------------------------------
        // Utility functions to avoid repetition
        private bool IsUserSelected()
        {
            if (usersListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a user.");
                return false;
            }
            return true;
        }

        private string GetSelectedUsername() => usersListView.SelectedItems[0].Text;

        private bool IsSuperAdminSelected() => usersListView.SelectedItems[0].SubItems[5].Text == "Super Admin";

        private bool PreventSelfAction(string selectedUsername, string action)
        {
            if (selectedUsername == _currentAdminUsername)
            {
                MessageBox.Show($"You cannot {action} yourself.");
                return true;
            }
            return false;
        }

        // Handle the success/failure of operations like delete and demote
        private void HandleOperationResult(bool success, string successMessage, string failureMessage)
        {
            if (success)
            {
                MessageBox.Show(successMessage);
                LoadAdmins();  // Reload the ListView after the update
            }
            else
            {
                MessageBox.Show(failureMessage);
            }
        }

        //---------------------------------------------------------------------------------------
        // Minimize the form
        private void min_btn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // Exit the application
        private void cross_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //---------------------------------------------------------------------------------------
        // Handle navigation to other forms
        private void NavigateToForm(KryptonForm targetForm)
        {
            targetForm.StartPosition = FormStartPosition.Manual;
            targetForm.Location = this.Location;
            FormDesign.FadeTransition(this, targetForm);
            //targetForm.Show();
            //this.Hide();
        }

        private void dash_btn_Click(object sender, EventArgs e)
        {
            NavigateToForm(FormManager.GetDashForm());
        }

        private void Client_info_Click(object sender, EventArgs e)
        {
            NavigateToForm(FormManager.GetClientForm());
        }

        private void car_info_Click(object sender, EventArgs e)
        {
            NavigateToForm(FormManager.GetCarForm());
        }

        private void client_btn_Click(object sender, EventArgs e)
        {
            NavigateToForm(FormManager.GetUserForm());
        }
    }
}
