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
    public partial class Gallery : KryptonForm
    {
        // Dictionary to map small image PictureBoxes to their corresponding GIFs
        private Dictionary<PictureBox, Image> carImageToGifMapping = new Dictionary<PictureBox, Image>();
        private Image currentDisplayedImage = null; // Track the currently displayed image for disposal

        // Track panels in a list to manage color changes
        private List<Panel> panels;
        private Dictionary<PictureBox, Panel> pictureBoxToPanelMapping; // Mapping between PictureBox and Panel
        private Color originalColor = Color.FromArgb(50, 64, 64, 64);  // Original panel color
        private Color clickedColor = Color.FromArgb(100, 158, 22, 22); // Clicked color
        private Panel activePanel = null; // Track the currently clicked panel

        private readonly ClientBookingService _bookingService;

        // Constructor - Initializes form, panels, and car gallery
        //--------------------------------------------------------------------------------------
        public Gallery()
        {
            InitializeComponent();
            InitializePanels(); // Setup panels and their initial colors
            InitializeCarGallery(); // Load car images and GIFs

            // Initialize the BookingService with the DatabaseConnection
            _bookingService = new ClientBookingService(new DatabaseConnection());

            try
            {
                // Apply rounded corners and make the form draggable
                FormDesign.ApplyRoundedCorners(this, 7);
                FormDesign.MakeFormDraggable(this, top_panel);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error applying rounded corners: " + ex.Message);
            }
        }
        //--------------------------------------------------------------------------------------


        // Initialize panels and map PictureBoxes to their respective panels
        //--------------------------------------------------------------------------------------
        private void InitializePanels()
        {
            // Store all the panels in a list for easy access
            panels = new List<Panel> { picpanel1, picpanel2, picpanel3, picpanel4, picpanel5 };

            // Set the initial background color for each panel
            foreach (Panel panel in panels)
            {
                panel.BackColor = originalColor;
            }

            // Map each PictureBox to its corresponding panel
            pictureBoxToPanelMapping = new Dictionary<PictureBox, Panel>
            {
                { pictureBoxSmallCar1, picpanel1 },
                { pictureBoxSmallCar2, picpanel2 },
                { pictureBoxSmallCar3, picpanel3 },
                { pictureBoxSmallCar4, picpanel4 },
                { pictureBoxSmallCar5, picpanel5 }
            };
        }
        //--------------------------------------------------------------------------------------


        // Load car images into small PictureBoxes and GIFs for the large PictureBox
        //--------------------------------------------------------------------------------------
        private void InitializeCarGallery()
        {
            try
            {
                // Load static images into small PictureBoxes
                pictureBoxSmallCar1.Image = ImageManager.GetImage("GalCar1");
                pictureBoxSmallCar2.Image = ImageManager.GetImage("GalCar2");
                pictureBoxSmallCar3.Image = ImageManager.GetImage("GalCar3");
                pictureBoxSmallCar4.Image = ImageManager.GetImage("GalCar4");
                pictureBoxSmallCar5.Image = ImageManager.GetImage("GalCar5");

                // Load GIFs for each small PictureBox into the mapping dictionary
                carImageToGifMapping[pictureBoxSmallCar1] = ImageManager.GetImage("GIF1");
                carImageToGifMapping[pictureBoxSmallCar2] = ImageManager.GetImage("GIF2");
                carImageToGifMapping[pictureBoxSmallCar3] = ImageManager.GetImage("GIF3");
                carImageToGifMapping[pictureBoxSmallCar4] = ImageManager.GetImage("GIF4");
                carImageToGifMapping[pictureBoxSmallCar5] = ImageManager.GetImage("GIF5");

                // Attach click event handler to each PictureBox
                foreach (var pictureBox in carImageToGifMapping.Keys)
                {
                    pictureBox.Click += SmallPictureBox_Click;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error initializing the gallery: " + ex.Message);
            }
        }
        //--------------------------------------------------------------------------------------


        // Helper method to load an image or return a placeholder if the image is missing
        //--------------------------------------------------------------------------------------
        private Image LoadImageOrPlaceholder(string imageKey)
        {
            Image image = ImageManager.GetImage(imageKey);
            return image ?? ImageManager.GetPlaceholderImage(); // Return placeholder if the image is not found
        }
        //--------------------------------------------------------------------------------------


        // Event handler for small PictureBox click, displays the corresponding GIF in the large PictureBox
        //--------------------------------------------------------------------------------------
        private void SmallPictureBox_Click(object sender, EventArgs e)
        {
            if (sender is PictureBox clickedPictureBox && carImageToGifMapping.ContainsKey(clickedPictureBox))
            {
                // Dispose the currently displayed image to free resources
                currentDisplayedImage?.Dispose();

                // Clone and display the selected GIF in the large PictureBox
                currentDisplayedImage = (Image)carImageToGifMapping[clickedPictureBox].Clone();
                pictureBoxLargeCar.Image = currentDisplayedImage;

                // Update panel colors to reflect the active panel
                if (pictureBoxToPanelMapping.TryGetValue(clickedPictureBox, out Panel associatedPanel))
                {
                    ResetPanelColors(); // Reset all panels to the original color
                    associatedPanel.BackColor = clickedColor; // Highlight the selected panel
                    activePanel = associatedPanel; // Track the active panel
                }
            }
        }
        //--------------------------------------------------------------------------------------


        // Helper method to reset all panel colors to the original state
        //--------------------------------------------------------------------------------------
        private void ResetPanelColors()
        {
            foreach (Panel panel in panels)
            {
                panel.BackColor = originalColor;
            }
        }
        //--------------------------------------------------------------------------------------


        // Dispose resources (images) when the form is closed to free memory
        //--------------------------------------------------------------------------------------
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);

            // Dispose the currently displayed large image
            currentDisplayedImage?.Dispose();

            // Dispose all cached images using ImageManager
            ImageManager.DisposeAllImages();
        }
        //--------------------------------------------------------------------------------------


        // Close button click handler, confirms exit and logs out if confirmed
        //--------------------------------------------------------------------------------------
        private void cross_btn_Click(object sender, EventArgs e)
        {
            this.Opacity = 0.5; // Reduce form opacity to indicate modal state

            using (var confirmLogout = new ConfirmLogout())
            {
                var result = confirmLogout.ShowDialog();

                if (result == DialogResult.OK)
                {
                    this.Opacity = 1.0; // Restore opacity before closing
                    Application.Exit();
                }
                else
                {
                    this.Opacity = 1.0; // Restore opacity if logout is canceled
                }
            }
        }
        //--------------------------------------------------------------------------------------


        // Minimize button click handler, minimizes the form
        //--------------------------------------------------------------------------------------
        private void min_btn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //--------------------------------------------------------------------------------------


        // Home button click handler, navigates back to MainForm
        //--------------------------------------------------------------------------------------
        private void home_btn_Click(object sender, EventArgs e)
        {
            MainForm mainForm = FormManager.GetDashboardForm();
            mainForm.StartPosition = FormStartPosition.Manual;
            mainForm.Location = this.Location; // Maintain current window position
            FormDesign.FadeTransition(this, mainForm);
            //this.Hide();
            //mainForm.Show();

        }
        //--------------------------------------------------------------------------------------


        // Settings button click handler, opens the SettingsForm
        //--------------------------------------------------------------------------------------
        private void settings_btn_Click(object sender, EventArgs e)
        {
            Settings settings = FormManager.GetSettingsForm();
            settings.StartPosition = FormStartPosition.Manual;
            settings.Location = this.Location; // Maintain current window position
            FormDesign.FadeTransition(this, settings);
            //this.Hide();
            //settings.Show();

        }
        //--------------------------------------------------------------------------------------


        // Book button click handler, checks user information completeness before proceeding to the booking form
        //--------------------------------------------------------------------------------------
        private void book_btn_Click(object sender, EventArgs e)
        {
            string currentUsername = FormManager.GetLoggedInUsername();

            // Check if user has completed their profile info
            if (!_bookingService.IsUserInfoComplete(currentUsername))
            {
                MessageBox.Show("Please complete your Name, Address, and Phone information in the Settings before booking.",
                    "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return; // Exit if information is incomplete
            }

            // If info is complete, open the Booking form
            Booking bookingForm = FormManager.GetBookingForm();
            bookingForm.StartPosition = FormStartPosition.Manual;
            bookingForm.Location = this.Location; // Maintain current window position
            FormDesign.FadeTransition(this, bookingForm);
            //this.Hide();
            //bookingForm.Show();

        }
        //--------------------------------------------------------------------------------------
    }
}
