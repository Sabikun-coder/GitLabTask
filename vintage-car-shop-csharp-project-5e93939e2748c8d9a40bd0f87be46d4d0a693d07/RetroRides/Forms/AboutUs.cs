using RetroRides.Utilities;
using System;
using System.Windows.Forms;

namespace RetroRides.Forms
{
    public partial class AboutUs : Form
    {
        public AboutUs()
        {
            InitializeComponent();
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

        private void cross_btn_Click(object sender, EventArgs e)
        {
            // Get the Form1 (login form) instance
            Login login = FormManager.GetLoginForm();
            login.StartPosition = FormStartPosition.Manual; // Set the location of the new form to be the same as the current form
            login.Location = this.Location;
            login.Show();
            this.Hide();
        }

        private void min_btn_Click(object sender, EventArgs e)
        {
            // Minimize the form
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
