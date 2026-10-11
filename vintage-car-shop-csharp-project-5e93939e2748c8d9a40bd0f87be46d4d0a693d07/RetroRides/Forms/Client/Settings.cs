using ComponentFactory.Krypton.Toolkit;
using RetroRides.BLL.Client;
using RetroRides.Data;
using RetroRides.Utilities;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace RetroRides.Forms.Client
{
    public partial class Settings : KryptonForm
    {
        private readonly SettingsService _settingsService;
        private readonly ClientBookingService _bookingService;
        private string _currentUsername; // Current username of the logged-in user

        //--------------------------------------------------------------------------------------
        // Constructor: Initializes the Settings form, services, placeholders, and form design
        //--------------------------------------------------------------------------------------
        public Settings()
        {
            InitializeComponent();

            // Initialize services
            var dbConnection = new DatabaseConnection();
            _settingsService = new SettingsService(dbConnection);
            _bookingService = new ClientBookingService(dbConnection);

            // Retrieve the logged-in username
            _currentUsername = FormManager.GetLoggedInUsername();

            // Set up placeholders, event handlers, and form design
            AttachPlaceholderHandlers();
            LoadUserInfo(_currentUsername);
            InitializePlaceholders();
            ApplyFormDesign();
        }

        //--------------------------------------------------------------------------------------
        // Apply form design (rounded corners, draggable panel)
        //--------------------------------------------------------------------------------------
        private void ApplyFormDesign()
        {
            try
            {
                FormDesign.ApplyRoundedCorners(this, 7);
                FormDesign.MakeFormDraggable(this, panel1);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error applying rounded corners: " + ex.Message);
            }
        }

        //--------------------------------------------------------------------------------------
        // Initialize placeholders for fields
        //--------------------------------------------------------------------------------------
        private void InitializePlaceholders()
        {
            SetPlaceholder(nameField, "Enter your name*");
            SetPlaceholder(addressField, "Enter your address*");
            currentUserField.Text = _currentUsername; // Pre-fill with the current username
            SetPlaceholder(newUsernameField, "New username (if needed)");
            SetPlaceholder(passwordField, "Enter your password*", isPassword: true);
            SetPlaceholder(newPasswordField, "New password (if needed)", isPassword: true);
            SetPlaceholder(phoneField, "Enter phone number*");
        }


        // Helper to set placeholder text with an optional force flag
        private void SetPlaceholder(KryptonTextBox field, string placeholder, bool isPassword = false, bool force = false)
        {
            if (force || string.IsNullOrWhiteSpace(field.Text))
            {
                field.Text = placeholder;
                field.PasswordChar = isPassword ? '\0' : field.PasswordChar;
            }
        }


        // Force reset placeholders regardless of the current content in the fields
        private void ForceResetPlaceholders()
        {
            SetPlaceholder(nameField, "Enter your name*", force: true);
            SetPlaceholder(addressField, "Enter your address*", force: true);
            currentUserField.Text = _currentUsername; // Pre-fill with the current username
            SetPlaceholder(newUsernameField, "New username (if needed)", force: true);
            SetPlaceholder(passwordField, "Enter your password*", isPassword: true, force: true);
            SetPlaceholder(newPasswordField, "New password (if needed)", isPassword: true, force: true);
            SetPlaceholder(phoneField, "Enter phone number*", force: true);
        }


        //--------------------------------------------------------------------------------------
        // Load user info and populate fields
        //--------------------------------------------------------------------------------------
        private void LoadUserInfo(string username)
        {
            try
            {
                var (name, address, phone, usernameDb) = _settingsService.LoadUserInfo(username);
                nameField.Text = name ?? "Enter your name*";
                addressField.Text = address ?? "Enter your address*";
                phoneField.Text = phone ?? "Enter phone number*";
                currentUserField.Text = usernameDb ?? _currentUsername;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading user data: {ex.Message}");
            }
        }

        //--------------------------------------------------------------------------------------
        // Attach placeholder event handlers for Enter and Leave events
        //--------------------------------------------------------------------------------------
        private void AttachPlaceholderHandlers()
        {
            AttachPlaceholderHandler(nameField, "Enter your name*");
            AttachPlaceholderHandler(addressField, "Enter your address*");
            AttachPlaceholderHandler(phoneField, "Enter phone number*");
            AttachPlaceholderHandler(currentUserField, "Enter current username*");
            AttachPlaceholderHandler(newUsernameField, "New username (if needed)");
            AttachPasswordHandler(passwordField, "Enter your password*");
            AttachPasswordHandler(newPasswordField, "New password (if needed)");
        }

        // Attach handlers for text fields
        private void AttachPlaceholderHandler(KryptonTextBox field, string placeholder)
        {
            field.Enter += (s, e) => InputValidator.HandleEnter(field, placeholder, Color.Black);
            field.Leave += (s, e) => InputValidator.HandleLeave(field, placeholder, Color.DimGray);
        }

        // Attach handlers for password fields
        private void AttachPasswordHandler(KryptonTextBox field, string placeholder)
        {
            field.Enter += (s, e) => InputValidator.HandlePasswordEnter(field, placeholder, showpasscheck);
            field.Leave += (s, e) => InputValidator.HandlePasswordLeave(field, placeholder, showpasscheck);
        }

        //--------------------------------------------------------------------------------------
        // Toggle visibility of password fields based on checkbox state
        //--------------------------------------------------------------------------------------
        private void showpasscheck_CheckedChanged(object sender, EventArgs e)
        {
            InputValidator.TogglePasswordVisibility(
                showpasscheck,
                passwordField, "Enter your password*",
                newPasswordField, "New password (if needed)"
            );
        }

        //--------------------------------------------------------------------------------------
        // Apply button: Validate and update user settings
        //--------------------------------------------------------------------------------------
        private void apply_btn_Click(object sender, EventArgs e)
        {
            // Validate required fields
            if (!InputValidator.AreFieldsFilledWithPlaceholders(
                (nameField, "Enter your name*"),
                (addressField, "Enter your address*"),
                (currentUserField, "Enter current username*"),
                (passwordField, "Enter your password*"),
                (phoneField, "Enter phone number*")))
            {
                KryptonMessageBox.Show("Please fill in all mandatory fields.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate phone number
            if (!InputValidator.IsPhoneNumberValid(phoneField.Text.Trim()))
            {
                KryptonMessageBox.Show("Please enter a valid phone number (digits only).", "Invalid Phone Number", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate credentials
            if (_settingsService.IsValidCurrentCredentials(currentUserField.Text, passwordField.Text))
            {
                // Handle updates for username and password
                ConfirmAndUpdateUserDetails();
            }
            else
            {
                KryptonMessageBox.Show("Invalid current username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Confirm and update user details if necessary
        private void ConfirmAndUpdateUserDetails()
        {
            string newUsername = GetOptionalField(newUsernameField, "New username (if needed)");

            // Check if the new username already exists, if it's being updated
            if (!string.IsNullOrWhiteSpace(newUsername) && _settingsService.UsernameExists(newUsername))
            {
                KryptonMessageBox.Show("The username already exists. Please choose a different username.", "Username Exists", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string message = BuildUpdateMessage();
            if (!string.IsNullOrEmpty(message))
            {
                var result = KryptonMessageBox.Show(message, "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No) return;
            }

            int rowsAffected = _settingsService.UpdateUserDetails(
                nameField.Text.Trim(),
                addressField.Text.Trim(),
                currentUserField.Text.Trim(),
                newUsername,
                GetOptionalField(newPasswordField, "New password (if needed)"),
                phoneField.Text.Trim()
            );

            if (rowsAffected > 0)
            {
                KryptonMessageBox.Show("Settings updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Update username if changed
                if (!string.IsNullOrWhiteSpace(newUsername) && newUsername != _currentUsername)
                {
                    _currentUsername = newUsername;
                    FormManager.SetLoggedInUsername(_currentUsername);
                }
            }
            else
            {
                KryptonMessageBox.Show("No rows were updated. Please check your input.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Helper to build the confirmation message for username/password update
        private string BuildUpdateMessage()
        {
            string message = string.Empty;
            bool isUsernameUpdate = !InputValidator.IsFieldEmptyOrPlaceholder(newUsernameField, "New username (if needed)");
            bool isPasswordUpdate = !InputValidator.IsFieldEmptyOrPlaceholder(newPasswordField, "New password (if needed)");

            message += "Do you want to update";

            if (isUsernameUpdate)
                message += " username?";

            if (isPasswordUpdate)
                message += (message.Length > 0 ? " And " : string.Empty) + "password?";

            return message;
        }

        // Helper to get optional field value or null
        private string GetOptionalField(KryptonTextBox field, string placeholder)
        {
            return !InputValidator.IsFieldEmptyOrPlaceholder(field, placeholder) ? field.Text.Trim() : null;
        }

        //--------------------------------------------------------------------------------------
        // Other Button Handlers: Reset, Navigation, and Logout
        //--------------------------------------------------------------------------------------
        private void reset_btn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForceResetPlaceholders(); // Force reset all fields to placeholders
        }

        private void goback_btn_Click(object sender, EventArgs e)
        {
            NavigateToMainForm();
        }

        private void home_btn_Click(object sender, EventArgs e)
        {
            NavigateToMainForm();
        }

        // Navigate to MainForm
        private void NavigateToMainForm()
        {
            MainForm mainForm = FormManager.GetDashboardForm();
            mainForm.StartPosition = FormStartPosition.Manual;
            mainForm.Location = this.Location;
            FormDesign.FadeTransition(this, mainForm);
            //mainForm.Show();
            //this.Hide();
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            // Confirm logout and exit
            this.Opacity = 0.5;
            using (var confirmLogout = new ConfirmLogout())
            {
                if (confirmLogout.ShowDialog() == DialogResult.OK)
                {
                    this.Opacity = 1.0;
                    Application.Exit();
                }
                else
                {
                    this.Opacity = 1.0;
                }
            }
        }

        private void min_btn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized; // Minimize the form
        }

        //--------------------------------------------------------------------------------------
        // Button Handlers for Booking and Gallery
        //--------------------------------------------------------------------------------------
        private void booking_button_Click(object sender, EventArgs e)
        {
            string currentUsername = FormManager.GetLoggedInUsername();

            if (!_bookingService.IsUserInfoComplete(currentUsername))
            {
                MessageBox.Show("Please complete your Name, Address, and Phone information in the Settings before booking.",
                    "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Booking bookingForm = FormManager.GetBookingForm();
            bookingForm.StartPosition = FormStartPosition.Manual;
            bookingForm.Location = this.Location;
            FormDesign.FadeTransition(this, bookingForm);
            //this.Hide();
            //bookingForm.Show();
        }

        private void view_gallery_Click(object sender, EventArgs e)
        {
            Gallery galForm = FormManager.GetGalleryForm();
            galForm.StartPosition = FormStartPosition.Manual;
            galForm.Location = this.Location;
            FormDesign.FadeTransition(this, galForm);
            //galForm.Show();
            //this.Hide();
        }
    }
}
