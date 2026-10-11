using ComponentFactory.Krypton.Toolkit;
using RetroRides.BLL;
using RetroRides.Data;
using RetroRides.Utilities;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace RetroRides.Forms
{
    public partial class Registration : KryptonForm
    {
        private readonly RegistrationService _registrationService;

        public Registration()
        {
            InitializeComponent();


            // Use KeystrokeHelper to handle Enter key for username, password, and confirm password boxes
            KeyStrokes.SubscribeToEnterKey(usernamebox, signup_btn);
            KeyStrokes.SubscribeToEnterKey(passwordbox, signup_btn);
            KeyStrokes.SubscribeToEnterKey(passwordbox2, signup_btn);

            // Initialize RegistrationService without directly initializing the dbConnection here
            _registrationService = new RegistrationService(new DatabaseConnection());


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




        }








        //BUTTON FUNCTIONS:
        //------------------------------------------------------------

        //closes the app
        private void cancel_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void min_btn_Click(object sender, EventArgs e)
        {
            // Minimize the form
            this.WindowState = FormWindowState.Minimized;
        }


        private void signin_btn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Get the Login form instance
            Login login = FormManager.GetLoginForm();
            login.StartPosition = FormStartPosition.Manual;
            login.Location = this.Location;
            FormDesign.FadeTransition(this, login);
            //this.Hide();
            //login.Show();


        }



        private void signup_btn_Click(object sender, EventArgs e)
        {

            // First, check if all fields are filled (including placeholder check)
            if (!InputValidator.AreFieldsFilledWithPlaceholders(
                (usernamebox, "Enter your username"),
                (passwordbox, "Enter your password"),
                (passwordbox2, "Confirm your password")))
            {
                KryptonMessageBox.Show("Please fill in all fields.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Then, check if the passwords match
            if (!InputValidator.ArePasswordsMatching(passwordbox, "Enter your password", passwordbox2, "Confirm your password"))
            {
                KryptonMessageBox.Show("Passwords do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Check if the username already exists
                if (_registrationService.IsUsernameTaken(usernamebox.Text))
                {
                    KryptonMessageBox.Show("Username already taken. Please choose another one.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Register the user
                if (_registrationService.RegisterUser(usernamebox.Text, passwordbox.Text))
                {
                    MessageBox.Show("Account created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    Login login = FormManager.GetLoginForm();
                    login.StartPosition = FormStartPosition.Manual;
                    login.Location = this.Location;
                    FormDesign.FadeTransition(this, login);
                    //this.Hide();
                    //login.Show();


                }
                else
                {
                    MessageBox.Show("Failed to create account. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //------------------------------------------------------------









        //Automatically clear textboxes AND INPUT validations:
        //------------------------------------------------------------

        //show or mask the password
        private void showpasscheck_CheckedChanged(object sender, EventArgs e)
        {
            // Use the inputvalidator to toggle visibility for both password and confirm password fields
            InputValidator.TogglePasswordVisibility(showpasscheck, passwordbox, "Enter your password", passwordbox2, "Confirm your password");

        }

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

        private void passwordbox2_Enter(object sender, EventArgs e)
        {
            // Clear placeholder text when the user clicks the TextBox
            InputValidator.HandlePasswordEnter(passwordbox2, "Confirm your password", showpasscheck);
        }

        private void passwordbox2_Leave(object sender, EventArgs e)
        {
            // Restore placeholder text if the TextBox is empty
            InputValidator.HandlePasswordLeave(passwordbox2, "Confirm your password", showpasscheck);
        }


        //------------------------------------------------------------



    }
}
