using ComponentFactory.Krypton.Toolkit;
using RetroRides.BLL;
using RetroRides.Data;
using RetroRides.Forms.Admin;
using RetroRides.Forms.Client;
using RetroRides.Utilities;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace RetroRides.Forms
{
    public partial class Login : KryptonForm
    {

        private readonly LoginService _loginService;


        public Login()
        {
            InitializeComponent();

            // Initialize LoginService with the DatabaseConnection
            _loginService = new LoginService(new DatabaseConnection());

        }





        // Form Load Event
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                // Apply rounded corners
                FormDesign.ApplyRoundedCorners(this, 7);
                // Make form draggable
                FormDesign.MakeFormDraggable(this, panel1);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error applying rounded corners: " + ex.Message);
            }


            // Use KeystrokeHelper to handle Enter key for both username and password boxes
            KeyStrokes.SubscribeToEnterKey(usernamebox, login_btn);
            KeyStrokes.SubscribeToEnterKey(passwordbox, login_btn);



        }





        //Automatically clear textboxes when moving away:
        //------------------------------------------------------------

        private void usernamebox_Enter(object sender, EventArgs e)
        {
            // Clear text when the user clicks the TextBox
            InputValidator.HandleEnter(usernamebox, "Enter your username", Color.Black);
        }

        private void usernamebox_Leave(object sender, EventArgs e)
        {
            // Restore placeholder text if the TextBox is empty
            InputValidator.HandleLeave(usernamebox, "Enter your username", Color.DimGray);
        }


        private void passwordbox_Enter(object sender, EventArgs e)
        {
            // Clear placeholder text when the user clicks the TextBox
            InputValidator.HandlePasswordEnter(passwordbox, "Enter your password", showpasscheck);
        }

        private void passwordbox_Leave(object sender, EventArgs e)
        {
            // Restore placeholder text if the TextBox is empty
            InputValidator.HandlePasswordLeave(passwordbox, "Enter your password", showpasscheck);
        }
        //------------------------------------------------------------












        //BUTTON FUNCTIONS:
        //------------------------------------------------------------

        private void login_btn_Click(object sender, EventArgs e)
        {

            // Validate that all fields are filled
            if (!InputValidator.AreFieldsFilledWithPlaceholders((usernamebox, "Enter your username"), (passwordbox, "Enter your password")))
            {
                KryptonMessageBox.Show("Please fill in all fields.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // We gonna use LoginService to validate the credentials
                var (isSuccess, isAdmin, isSuperAdmin) = _loginService.ValidateLogin(usernamebox.Text, passwordbox.Text);

                if (isSuccess)
                {
                    KryptonMessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Set the logged-in username in FormManager for reuse
                    FormManager.SetLoggedInUsername(usernamebox.Text);



                    if (isSuperAdmin)
                    {
                        AdminDashboard dash = FormManager.GetDashForm();
                        FormDesign.FadeTransition(this, dash);
                        //this.Hide();
                        //dash.Show();

                    }
                    else if (isAdmin)
                    {
                        AdminDashboard dash = FormManager.GetDashForm();
                        FormDesign.FadeTransition(this, dash);
                        //this.Hide();
                        //dash.Show();

                    }
                    else
                    {
                        MainForm mainForm = FormManager.GetDashboardForm();
                        FormDesign.FadeTransition(this, mainForm);
                        //this.Hide();
                        //mainForm.Show();

                    }
                }
                else
                {
                    KryptonMessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                KryptonMessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }


        private void create_acc_btn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {


            // Get the Registration form instance
            Registration regForm = FormManager.GetRegistrationForm();
            regForm.StartPosition = FormStartPosition.Manual; // Set the location of the new form to be the same as the current form
            regForm.Location = this.Location;
            FormDesign.FadeTransition(this, regForm);
            //this.Hide();
            // regForm.Show();


        }

        private void showpasscheck_CheckedChanged(object sender, EventArgs e)
        {
            // Use the inputvalidator to toggle visibility
            InputValidator.TogglePasswordVisibility(showpasscheck, passwordbox, "Enter your password");


        }



        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        //This piece of Code is to Minimize the app.
        private void button3_Click(object sender, EventArgs e)
        {
            // Minimize the form
            this.WindowState = FormWindowState.Minimized;
        }



        private void aboutus_Click(object sender, EventArgs e)
        {
            AboutUs us = new AboutUs();
            us.Show();
            this.Hide();
        }


        //------------------------------------------------------------



    }
}
