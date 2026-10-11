using ComponentFactory.Krypton.Toolkit;
using RetroRides.BLL.Admin;
using RetroRides.Data;
using RetroRides.Utilities;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace RetroRides.Forms.Admin
{
    public partial class AdminCarManager : KryptonForm
    {
        private readonly CarService _carService;

        public AdminCarManager()
        {
            InitializeComponent();

            // Initialize CarService with a database connection
            _carService = new CarService(new DatabaseConnection());

            // Setup the form design (rounded corners, draggable)
            ApplyFormDesign();

            // Load car data into the DataGridView
            LoadCarData();
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
        // Load car data into the DataGridView
        private void LoadCarData()
        {
            DataTable carData = _carService.LoadCarData();
            dataGridViewCars.DataSource = carData;
        }

        //---------------------------------------------------------------------------------------
        // Handle cell click event in DataGridView to populate form fields with selected car's data
        private void dataGridViewCars_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridViewCars.Rows.Count - 1)
            {
                DataGridViewRow row = dataGridViewCars.Rows[e.RowIndex];
                PopulateCarDetails(row);
            }
        }

        //---------------------------------------------------------------------------------------
        // Populate the form fields with the selected car's data
        private void PopulateCarDetails(DataGridViewRow row)
        {
            if (row.Cells["CarID"].Value != null)
            {
                txtCarID.Text = row.Cells["CarID"].Value.ToString();
                txtModelName.Text = row.Cells["ModelName"].Value.ToString();
                txtYear.Text = row.Cells["YearOfManufacture"].Value.ToString();
                txtTopSpeed.Text = row.Cells["TopSpeed"].Value.ToString();
                txtMaxPower.Text = row.Cells["MaxPower"].Value.ToString();
                txtPrice.Text = row.Cells["Price"].Value.ToString();
                txtDescription.Text = row.Cells["Description"].Value.ToString();
                txtImagePath.Text = row.Cells["ImagePath"].Value.ToString();

                LoadCarImage(row.Cells["ImagePath"].Value.ToString());
            }
        }

        //---------------------------------------------------------------------------------------
        // Load the car image from the provided path and handle exceptions
        private void LoadCarImage(string imagePath)
        {
            if (!string.IsNullOrEmpty(imagePath))
            {
                try
                {
                    pictureBoxCar.Image = Image.FromFile(imagePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading image: {ex.Message}");
                    pictureBoxCar.Image = null;
                }
            }
            else
            {
                pictureBoxCar.Image = null;
            }
        }

        //---------------------------------------------------------------------------------------
        // Validate form fields before submitting
        private bool ValidateFields()
        {
            if (string.IsNullOrWhiteSpace(txtModelName.Text) || txtModelName.Text == "Model name")
            {
                MessageBox.Show("Please enter the model name.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtYear.Text) || txtYear.Text == "Year" ||
                !int.TryParse(txtYear.Text, out int year) || year < 1886 || year > DateTime.Now.Year)
            {
                MessageBox.Show("Please enter the valid year of manufacture.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtTopSpeed.Text) || txtTopSpeed.Text == "Top speed in km/h"
                || !int.TryParse(txtTopSpeed.Text, out int topSpeed) || topSpeed <= 0)
            {
                MessageBox.Show("Please enter the top speed.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtMaxPower.Text) || txtMaxPower.Text == "Max power (HP)"
                || !int.TryParse(txtMaxPower.Text, out int maxPower) || maxPower <= 0)
            {
                MessageBox.Show("Please enter the max power.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtPrice.Text) || txtPrice.Text == "Price in BDT" ||
                !decimal.TryParse(txtPrice.Text, out decimal price) || price <= 0)
            {
                MessageBox.Show("Please enter the price.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtDescription.Text) || txtDescription.Text == "Write a short description")
            {
                MessageBox.Show("Please enter a description.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtImagePath.Text) || txtImagePath.Text == "Image path")
            {
                MessageBox.Show("Please provide the image path.");
                return false;
            }

            return true;
        }

        //---------------------------------------------------------------------------------------
        // Get relative image path

        private string GetRelativePath(string baseDirectory, string fullPath)
        {
            Uri baseUri = new Uri(baseDirectory);
            Uri fullUri = new Uri(fullPath);

            // Return the relative path
            return Uri.UnescapeDataString(baseUri.MakeRelativeUri(fullUri).ToString().Replace('/', Path.DirectorySeparatorChar));
        }

        //---------------------------------------------------------------------------------------
        // Event handlers for buttons (Add, Update, Delete)
        private void btnBrowseImage_Click(object sender, EventArgs e)
        {
            // Use Application.StartupPath for a more consistent base directory
            string projectDirectory = Application.StartupPath;

            // Set the relative path to the 'CarDbImages' folder inside the 'Resources' folder
            string relativeImagePath = Path.Combine(projectDirectory, @"Resources\Car Images\CarDbImages");

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                // Set the InitialDirectory to the relative image folder
                openFileDialog.InitialDirectory = relativeImagePath;
                openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png";
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Get the selected full file path
                    string selectedFilePath = openFileDialog.FileName;

                    // Display the relative file path in the TextBox
                    txtImagePath.Text = GetRelativePath(projectDirectory, selectedFilePath);

                    // Optionally, display the selected image in a PictureBox
                    pictureBoxCar.Image = Image.FromFile(openFileDialog.FileName);
                }
            }
        }

        //---------------------------------------------------------------------------------------
        // Add new car
        private void Add_Click(object sender, EventArgs e)
        {
            if (!ValidateFields())
                return;

            bool success = _carService.AddCar(
                txtModelName.Text,
                int.Parse(txtYear.Text),
                int.Parse(txtTopSpeed.Text),
                int.Parse(txtMaxPower.Text),
                decimal.Parse(txtPrice.Text),
                txtDescription.Text,
                txtImagePath.Text
            );

            HandleOperationResult(success, "Car added successfully!", "Failed to add car.");
        }

        //---------------------------------------------------------------------------------------
        // Update existing car
        private void update_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtCarID.Text, out int carid))
            {
                MessageBox.Show("Please select a car to update.");
                return;
            }

            bool success = _carService.UpdateCar(
                carid,
                txtModelName.Text,
                int.Parse(txtYear.Text),
                int.Parse(txtTopSpeed.Text),
                int.Parse(txtMaxPower.Text),
                decimal.Parse(txtPrice.Text),
                txtDescription.Text,
                txtImagePath.Text
            );

            HandleOperationResult(success, "Car updated successfully!", "Failed to update car.");
        }

        //---------------------------------------------------------------------------------------
        // Delete selected car
        private void delete_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtCarID.Text, out int carid))
            {
                MessageBox.Show("Please select a car to delete.");
                return;
            }

            bool success = _carService.DeleteCar(carid);
            HandleOperationResult(success, "Car deleted successfully!", "Failed to delete car.");
        }

        //---------------------------------------------------------------------------------------
        // Helper function to handle operation results for add/update/delete operations
        private void HandleOperationResult(bool success, string successMessage, string errorMessage)
        {
            if (success)
            {
                MessageBox.Show(successMessage);
                LoadCarData();
            }
            else
            {
                MessageBox.Show(errorMessage);
            }
        }

        //---------------------------------------------------------------------------------------
        // Form navigation buttons
        private void cross_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void min_btn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void NavigateToForm(KryptonForm targetForm)
        {
            targetForm.StartPosition = FormStartPosition.Manual;
            targetForm.Location = this.Location;
            FormDesign.FadeTransition(this, targetForm);
            //targetForm.Show();
            //this.Hide();
        }

        private void Client_info_Click(object sender, EventArgs e)
        {
            NavigateToForm(FormManager.GetClientForm());
        }

        private void client_btn_Click(object sender, EventArgs e)
        {
            NavigateToForm(FormManager.GetUserForm());
        }

        private void dash_btn_Click(object sender, EventArgs e)
        {
            NavigateToForm(FormManager.GetDashForm());
        }

        private void admin_btn_Click(object sender, EventArgs e)
        {
            NavigateToForm(FormManager.GetAdminForm());
        }

        //---------------------------------------------------------------------------------------
        // Input field event handlers for placeholders
        private void txtModelName_Enter(object sender, EventArgs e)
        {
            InputValidator.HandleEnter(txtModelName, "Model name", Color.Black);
        }

        private void txtModelName_Leave(object sender, EventArgs e)
        {
            InputValidator.HandleLeave(txtModelName, "Model name", Color.DimGray);
        }

        private void txtYear_Enter(object sender, EventArgs e)
        {
            InputValidator.HandleEnter(txtYear, "Year", Color.Black);
        }

        private void txtYear_Leave(object sender, EventArgs e)
        {
            InputValidator.HandleLeave(txtYear, "Year", Color.DimGray);
        }

        private void txtTopSpeed_Enter(object sender, EventArgs e)
        {
            InputValidator.HandleEnter(txtTopSpeed, "Top speed in km/h", Color.Black);
        }

        private void txtTopSpeed_Leave(object sender, EventArgs e)
        {
            InputValidator.HandleLeave(txtTopSpeed, "Top speed in km/h", Color.DimGray);
        }

        private void txtMaxPower_Enter(object sender, EventArgs e)
        {
            InputValidator.HandleEnter(txtMaxPower, "Max power (HP)", Color.Black);
        }

        private void txtMaxPower_Leave(object sender, EventArgs e)
        {
            InputValidator.HandleLeave(txtMaxPower, "Max power (HP)", Color.DimGray);
        }

        private void txtPrice_Enter(object sender, EventArgs e)
        {
            InputValidator.HandleEnter(txtPrice, "Price in BDT", Color.Black);
        }

        private void txtPrice_Leave(object sender, EventArgs e)
        {
            InputValidator.HandleLeave(txtPrice, "Price in BDT", Color.DimGray);
        }

        private void txtDescription_Enter(object sender, EventArgs e)
        {
            InputValidator.HandleEnter(txtDescription, "Write a short description", Color.Black);
        }

        private void txtDescription_Leave(object sender, EventArgs e)
        {
            InputValidator.HandleLeave(txtDescription, "Write a short description", Color.DimGray);
        }

        private void txtImagePath_Enter(object sender, EventArgs e)
        {
            InputValidator.HandleEnter(txtImagePath, "Image path", Color.Black);
        }

        private void txtImagePath_Leave(object sender, EventArgs e)
        {
            InputValidator.HandleLeave(txtImagePath, "Image path", Color.DimGray);
        }

        private void txtCarID_Enter(object sender, EventArgs e)
        {
            InputValidator.HandleEnter(txtCarID, "Enter car id to edit", Color.Black);
        }

        private void txtCarID_Leave(object sender, EventArgs e)
        {
            InputValidator.HandleLeave(txtCarID, "Enter car id to edit", Color.DimGray);
        }
    }
}
