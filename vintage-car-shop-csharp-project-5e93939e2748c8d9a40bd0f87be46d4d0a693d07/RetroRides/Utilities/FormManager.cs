using RetroRides.Forms;
using RetroRides.Forms.Admin;
using RetroRides.Forms.Client;
using System.Windows.Forms;




namespace RetroRides.Utilities
{
    public static class FormManager
    {
        private static Login loginForm;
        private static Registration registrationForm;
        private static MainForm mainForm;
        private static Gallery galleryForm;
        private static Settings settingsForm;
        private static Booking bookingForm;
        private static AdminBookingManager clientForm;
        private static AdminCarManager cmForm;
        private static AdminUserManager userForm;
        private static AdminDashboard dashForm;
        private static AdminManager adminForm;

        // Store the username for reuse
        private static string _loggedInUsername;

        public static void SetLoggedInUsername(string username)
        {
            _loggedInUsername = username;
        }

        public static string GetLoggedInUsername()
        {
            return _loggedInUsername;
        }


        public static Login GetLoginForm()
        {
            if (loginForm == null || loginForm.IsDisposed)
            {
                loginForm = new Login();  // Form1 is a KryptonForm
                loginForm.Opacity = 1;
            }
            return loginForm;
        }


        // Show Login form with Fade Transition
        public static void ShowLoginForm(Form currentForm)
        {
            var login = GetLoginForm();
            FormDesign.FadeTransition(currentForm, login);
        }


        public static Registration GetRegistrationForm()
        {
            if (registrationForm == null || registrationForm.IsDisposed)
            {
                registrationForm = new Registration();  // Registration is a KryptonForm
            }
            return registrationForm;
        }

        // Get MainForm and ensure fresh instance for new login
        public static MainForm GetDashboardForm()
        {
            // Dispose the previous instance to ensure data is refreshed on new login
            if (mainForm != null && !mainForm.IsDisposed)
            {
                mainForm.Dispose();
            }

            mainForm = new MainForm(_loggedInUsername);  // Pass the current username
            return mainForm;
        }

        public static Gallery GetGalleryForm()
        {
            // If no instance exists or it has been disposed, create a new one
            if (galleryForm == null || galleryForm.IsDisposed)
            {
                galleryForm = new Gallery();
            }
            return galleryForm;
        }

        // Get Settings Form and ensure fresh instance for new login
        public static Settings GetSettingsForm()
        {
            if (settingsForm != null && !settingsForm.IsDisposed)
            {
                settingsForm.Dispose();
            }

            settingsForm = new Settings();
            return settingsForm;
        }



        // Get Booking Form and ensure fresh instance for new login
        public static Booking GetBookingForm()
        {
            if (bookingForm != null && !bookingForm.IsDisposed)
            {
                bookingForm.Dispose();
            }

            bookingForm = new Booking();
            return bookingForm;
        }


        // Dispose old instances and return fresh instance of AdminBookingManager
        public static AdminBookingManager GetClientForm()
        {
            // Ensure fresh instance for new admin sessions
            if (clientForm != null && !clientForm.IsDisposed)
            {
                clientForm.Dispose();
            }

            clientForm = new AdminBookingManager();
            return clientForm;
        }

        // Dispose old instances and return fresh instance of AdminCarManager
        public static AdminCarManager GetCarForm()
        {
            if (cmForm != null && !cmForm.IsDisposed)
            {
                cmForm.Dispose();
            }

            cmForm = new AdminCarManager();
            return cmForm;
        }

        // Dispose old instances and return fresh instance of AdminUserManager
        public static AdminUserManager GetUserForm()
        {
            if (userForm != null && !userForm.IsDisposed)
            {
                userForm.Dispose();
            }

            userForm = new AdminUserManager();
            return userForm;
        }

        // Dispose old instances and return fresh instance of AdminDashboard
        public static AdminDashboard GetDashForm()
        {
            if (dashForm != null && !dashForm.IsDisposed)
            {
                dashForm.Dispose();
            }

            dashForm = new AdminDashboard();
            return dashForm;
        }


        // Dispose old instances and return fresh instance of AdminManager
        public static AdminManager GetAdminForm()
        {
            if (adminForm != null && !adminForm.IsDisposed)
            {
                adminForm.Dispose();
            }

            adminForm = new AdminManager();
            return adminForm;
        }



        // Call this method to log out admin and clear all admin forms
        public static void AdminLogOut()
        {
            // Dispose all admin forms to ensure they don't retain old data
            if (clientForm != null && !clientForm.IsDisposed) clientForm.Dispose();
            if (cmForm != null && !cmForm.IsDisposed) cmForm.Dispose();
            if (userForm != null && !userForm.IsDisposed) userForm.Dispose();
            if (dashForm != null && !dashForm.IsDisposed) dashForm.Dispose();

            // Optionally reset the logged-in username
            _loggedInUsername = null;

            // Show login form or take the necessary action to complete logout

            ShowLoginForm(null);
        }


        // Call this method when logging out
        public static void LogOut()
        {
            // Dispose any open forms that may still be active
            if (mainForm != null && !mainForm.IsDisposed) mainForm.Dispose();
            if (settingsForm != null && !settingsForm.IsDisposed) settingsForm.Dispose();
            if (bookingForm != null && !bookingForm.IsDisposed) bookingForm.Dispose();

            // Optionally reset the username
            _loggedInUsername = null;

            // Show login form again
            ShowLoginForm(null);
        }




    }
}