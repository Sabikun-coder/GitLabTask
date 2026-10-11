using ComponentFactory.Krypton.Toolkit;
using RetroRides.BLL.Client;
using RetroRides.Data;
using RetroRides.Utilities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace RetroRides.Forms.Client
{
    public partial class MainForm : KryptonForm
    {
        //VARIABLES FOR THE CAR SLIDESHOW:
        // Declare necessary fields
        private List<Image> carImages;  // Store car images in memory
        private int currentImageIndex = 0;  // Index to track the current image being displayed
        private int nextImageIndex = 1;  // Index for the next image to be displayed
        private int slideStep = 20;  // Number of pixels to move per step
        private int currentX = 0;  // X-coordinate of the current image
        private int nextX;  // X-coordinate of the next image

        // This variable is used to display the username that logs in
        private string _username;

        private readonly MainFormService _mainFormService;
        private readonly ClientBookingService _bookingService;

        public MainForm(string username) //parameterized constructor to take in the username
        {
            InitializeComponent();

            // Subscribe to PictureBox Paint event
            pictureBox1.Paint += new PaintEventHandler(pictureBox1_Paint);

            // Initialize the service class for business logic (ensure _mainFormService is initialized here)
            _mainFormService = new MainFormService(new DatabaseConnection());

            // Load car images via service
            carImages = _mainFormService.LoadCarImages();


            // Set the initial positions for the images
            currentX = 0;
            nextX = pictureBox1.Width;

            // Set the timer intervals
            slideshowTimer.Interval = 7000;  // 5 seconds for image change
            slideTimer.Interval = 35;  // 50 ms for smooth sliding transition

            // Attach event handlers for timers
            slideshowTimer.Tick += new EventHandler(SlideshowTimer_Tick);
            slideTimer.Tick += new EventHandler(SlideTimer_Tick);

            // Start the slideshow timer
            slideshowTimer.Start();

            // Get username from FormManager if not provided
            _username = username ?? FormManager.GetLoggedInUsername();
            DisplayWelcomeMessage();

            // Initialize the BookingService with the DatabaseConnection
            _bookingService = new ClientBookingService(new DatabaseConnection());


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




        // Method to display the welcome message
        //-----------------------------------------------------------
        private void DisplayWelcomeMessage()
        {
            welcomeLabel.Text = $"Welcome Back\n{_username}!";
        }


        // Refresh username each time the form is shown
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            // Get the updated username from the FormManager
            _username = FormManager.GetLoggedInUsername();
            DisplayWelcomeMessage(); // Refresh the welcome message
        }

        //-----------------------------------------------------------







        // Method to load car image paths (adjust paths accordingly in ImageManager.cs)
        //-----------------------------------------------------------
        private void LoadCarImages()
        {
            try
            {
                carImages.Add(ImageManager.GetImage("Car1"));
                carImages.Add(ImageManager.GetImage("Car2"));
                carImages.Add(ImageManager.GetImage("Car3"));
                carImages.Add(ImageManager.GetImage("Car4"));

                // Set initial positions for sliding effect
                currentX = 0;
                nextX = pictureBox1.Width;

                // Redraw the PictureBox with the first image
                pictureBox1.Invalidate();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading images: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        // Event handler for the slideshow timer (start the slide)
        private void SlideshowTimer_Tick(object sender, EventArgs e)
        {
            // Set the next image index
            nextImageIndex = (currentImageIndex + 1) % carImages.Count;  // Cycle through the images

            // Reset X-coordinates for sliding effect
            currentX = 0;  // Current image starts at 0
            nextX = pictureBox1.Width;  // Next image starts off-screen to the right

            // Start the sliding animation
            slideTimer.Start();
        }

        // Event handler for the sliding animation
        private void SlideTimer_Tick(object sender, EventArgs e)
        {
            // Move both images to the left (slide from right to left)
            currentX -= slideStep;
            nextX -= slideStep;

            // Invalidate the PictureBox to force it to repaint
            pictureBox1.Invalidate();

            // Check if the next image has fully slid into place
            if (nextX <= 0)
            {
                // Stop the sliding animation
                slideTimer.Stop();

                // Set the next image as the current image
                currentImageIndex = nextImageIndex;

                // Reset the position for the next image
                currentX = 0;
                nextX = pictureBox1.Width;
            }
        }

        // Event handler for painting the PictureBox with the sliding images
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (carImages.Count > 0)
            {
                // Draw the current image
                if (currentImageIndex < carImages.Count)
                {
                    e.Graphics.DrawImage(carImages[currentImageIndex], currentX, 0, pictureBox1.Width, pictureBox1.Height);
                }

                // Draw the next image (sliding in)
                if (nextImageIndex < carImages.Count)
                {
                    e.Graphics.DrawImage(carImages[nextImageIndex], nextX, 0, pictureBox1.Width, pictureBox1.Height);
                }
            }
        }

        // Dispose of images when the form is closed
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);

            // Dispose all loaded images via the ImageManager
            ImageManager.DisposeAllImages();
        }
        //-----------------------------------------------------------








        // BUTTON FUNCTIONS:
        //-----------------------------------------------------------
        private void cross_btn_Click(object sender, EventArgs e)
        {
            // Reduce form opacity to simulate darkening effect
            this.Opacity = 0.5;

            // Show the confirmation modal
            using (var confirmLogout = new ConfirmLogout())
            {
                var result = confirmLogout.ShowDialog();

                // If confirmed, log out and go back to the login form
                if (result == DialogResult.OK)
                {
                    // Restore the opacity **before** closing the form
                    this.Opacity = 1.0;
                    Application.Exit();
                }


                else
                {
                    // Restore the opacity if the user cancels
                    this.Opacity = 1.0;
                }
            }
        }

        private void min_btn_Click(object sender, EventArgs e)
        {
            // Minimize the form
            this.WindowState = FormWindowState.Minimized;
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            // Reduce form opacity to simulate darkening effect
            this.Opacity = 0.5;

            // Show the confirmation modal
            using (var confirmLogout = new ConfirmLogout())
            {
                var result = confirmLogout.ShowDialog();

                // If confirmed, log out and go back to the login form
                if (result == DialogResult.OK)
                {
                    // Restore the opacity **before** closing the form
                    this.Opacity = 1.0;


                    // Clear the logged-in username from FormManager
                    FormManager.LogOut();

                    // Hide MainForm
                    this.Hide();
                }
                else
                {
                    // Restore the opacity if the user cancels
                    this.Opacity = 1.0;
                }
            }

        }



        private void view_gallery_btn_Click(object sender, EventArgs e)
        {

            Gallery galForm = FormManager.GetGalleryForm();
            galForm.StartPosition = FormStartPosition.Manual; // Set the location of the new form to be the same as the current form
            galForm.Location = this.Location;
            FormDesign.FadeTransition(this, galForm);
            //this.Hide();
            //galForm.Show();

        }

        private void settings_btn_Click(object sender, EventArgs e)
        {
            // Get the instance of SettingsForm 
            Settings settings = FormManager.GetSettingsForm();
            settings.StartPosition = FormStartPosition.Manual; // Set the location of the new form to be the same as the current form
            settings.Location = this.Location;
            FormDesign.FadeTransition(this, settings);
            //this.Hide();
            //settings.Show();

        }

        private void booking_btn_Click(object sender, EventArgs e)
        {
            // Get the current username
            string currentUsername = FormManager.GetLoggedInUsername();

            // Check if the user's information is complete using BookingService
            if (!_bookingService.IsUserInfoComplete(currentUsername))
            {
                // Show message and redirect to the Settings form
                MessageBox.Show("Please complete your Name, Address, and Phone information in the Settings before booking.",
                    "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;  // Exit the method to prevent the BookingForm from opening
            }

            // If user info is complete, open the Booking form
            Booking bookingForm = FormManager.GetBookingForm();
            bookingForm.StartPosition = FormStartPosition.Manual;  // Set form location
            bookingForm.Location = this.Location;
            FormDesign.FadeTransition(this, bookingForm);
            //this.Hide();
            //bookingForm.Show();

        }

        private void ChooseModel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            // Get the current username
            string currentUsername = FormManager.GetLoggedInUsername();

            // Check if the user's information is complete using BookingService
            if (!_bookingService.IsUserInfoComplete(currentUsername))
            {
                // Show message and redirect to the Settings form
                MessageBox.Show("Please complete your Name, Address, and Phone information in the Settings before booking.",
                    "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;  // Exit the method to prevent the BookingForm from opening
            }

            // If user info is complete, open the Booking form
            Booking bookingForm = FormManager.GetBookingForm();
            bookingForm.StartPosition = FormStartPosition.Manual;  // Set form location
            bookingForm.Location = this.Location;
            FormDesign.FadeTransition(this, bookingForm);
            //this.Hide();
            //bookingForm.Show();

        }


        //-----------------------------------------------------------



    }
}
