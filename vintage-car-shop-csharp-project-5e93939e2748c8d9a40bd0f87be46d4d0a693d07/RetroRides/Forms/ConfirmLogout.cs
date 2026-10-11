using System;
using System.Windows.Forms;

namespace RetroRides.Forms
{
    public partial class ConfirmLogout : Form
    {
        public ConfirmLogout()
        {
            InitializeComponent();
        }


        private void yes_btn_Click(object sender, EventArgs e)
        {
            // Set the DialogResult to OK to confirm the action
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void no_btn_Click(object sender, EventArgs e)
        {
            // Set the DialogResult to Cancel if the user doesn't want to log out
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void ConfirmLogout_Load(object sender, EventArgs e)
        {

        }
    }
}
