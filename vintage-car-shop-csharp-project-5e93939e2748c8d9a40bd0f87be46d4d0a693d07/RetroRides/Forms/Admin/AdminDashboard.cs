using ComponentFactory.Krypton.Toolkit;
using RetroRides.Utilities;
using System;
using System.Windows.Forms;

namespace RetroRides.Forms.Admin
{
    public partial class AdminDashboard : KryptonForm
    {
        public AdminDashboard()
        {
            InitializeComponent();

            // Setup form design (rounded corners, draggable form)
            ApplyFormDesign();
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
        // General method to handle navigation to different forms
        private void NavigateToForm(KryptonForm targetForm)
        {
            targetForm.StartPosition = FormStartPosition.Manual;
            targetForm.Location = this.Location;
            FormDesign.FadeTransition(this, targetForm);
            //targetForm.Show();
            //this.Hide();
        }

        //---------------------------------------------------------------------------------------
        // Button click event handlers for navigation
        private void client_btn_Click(object sender, EventArgs e)
        {
            NavigateToForm(FormManager.GetUserForm());
        }

        private void bookings_info_Click(object sender, EventArgs e)
        {
            NavigateToForm(FormManager.GetClientForm());
        }

        private void car_info_Click(object sender, EventArgs e)
        {
            NavigateToForm(FormManager.GetCarForm());
        }

        private void admin_btn_Click(object sender, EventArgs e)
        {
            NavigateToForm(FormManager.GetAdminForm());
        }

        //---------------------------------------------------------------------------------------
        // Minimize the form
        private void min_btn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //---------------------------------------------------------------------------------------
        // Handle confirmation for logout or exit
        private void ConfirmLogout()
        {
            // Reduce form opacity to simulate darkening effect
            this.Opacity = 0.5;

            // Show the confirmation modal
            using (var confirmLogout = new ConfirmLogout())
            {
                var result = confirmLogout.ShowDialog();

                // If confirmed, perform the logout
                if (result == DialogResult.OK)
                {
                    this.Opacity = 1.0;  // Restore opacity before closing the form
                    FormManager.AdminLogOut();


                }
                else
                {
                    // Restore opacity if the user cancels
                    this.Opacity = 1.0;
                }
            }
        }

        //---------------------------------------------------------------------------------------
        // Cross (exit) button click event handler
        private void cross_btn_Click(object sender, EventArgs e)
        {
            ConfirmLogout();
        }

        //---------------------------------------------------------------------------------------
        // Logout button click event handler
        private void logout_btn_Click(object sender, EventArgs e)
        {
            ConfirmLogout();
        }
    }
}
