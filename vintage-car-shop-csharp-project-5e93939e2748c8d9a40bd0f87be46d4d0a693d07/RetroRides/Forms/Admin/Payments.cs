using ComponentFactory.Krypton.Toolkit;
using RetroRides.BLL.Admin;
using RetroRides.Data;
using System;
using System.Data;
using System.Windows.Forms;

namespace RetroRides.Forms.Admin
{
    public partial class Payments : KryptonForm
    {
        private readonly UserService _userService;
        private readonly int _userId;

        public Payments(int userId)
        {
            InitializeComponent();
            _userService = new UserService(new DatabaseConnection());
            _userId = userId;
            ConfigureListView();
            LoadPaymentInfo();
        }



        // Configure the ListView columns
        //----------------------------------------------------------------------------------------------------
        private void ConfigureListView()
        {
            paymentListView.View = View.Details;
            paymentListView.FullRowSelect = true;
            paymentListView.Columns.Add("Card Number", 150, HorizontalAlignment.Left);
            paymentListView.Columns.Add("Expiry Date", 100, HorizontalAlignment.Left);
            paymentListView.Columns.Add("Card Name", 150, HorizontalAlignment.Left);

        }
        //----------------------------------------------------------------------------------------------------






        // Load payment data from the database
        //----------------------------------------------------------------------------------------------------
        private void LoadPaymentInfo()
        {
            DataTable paymentData = _userService.GetPayments(_userId);

            // Clear the ListView before adding new data
            paymentListView.Items.Clear();

            // Populate the ListView with masked payment data
            foreach (DataRow row in paymentData.Rows)
            {
                // Mask the card number: Show only last 4 digits
                string cardNumber = row["CardNumber"].ToString();
                string maskedCardNumber = MaskCardNumber(cardNumber);

                // Mask the expiry date: Show full or partially masked (you can decide)
                string expiryDate = row["ExpiryDate"].ToString();
                string maskedExpiryDate = MaskExpiryDate(expiryDate); // Optional masking

                // Card name and remember flag are less sensitive
                string cardName = row["CardName"].ToString();
                string rememberCard = row["RememberCard"].ToString() == "1" ? "Yes" : "No";

                ListViewItem item = new ListViewItem(maskedCardNumber); // Masked Card Number
                item.SubItems.Add(maskedExpiryDate);                    // Masked Expiry Date
                item.SubItems.Add(cardName);                            // Card Name
                item.SubItems.Add(rememberCard);                        // Remember Card flag

                paymentListView.Items.Add(item);
            }
        }
        //----------------------------------------------------------------------------------------------------



        // Helper function to mask the card number (show last 4 digits)
        //----------------------------------------------------------------------------------------------------
        private string MaskCardNumber(string cardNumber)
        {
            if (cardNumber.Length > 4)
            {
                return new string('*', cardNumber.Length - 4) + cardNumber.Substring(cardNumber.Length - 4);
            }
            return cardNumber; // In case the card number is shorter than 4 digits, return as-is
        }

        // Optional helper function to mask expiry date (e.g., **/YY)
        private string MaskExpiryDate(string expiryDate)
        {
            if (expiryDate.Length == 5) // Assuming MM/YY format
            {
                return "**/" + expiryDate.Substring(3); // Mask only the month
            }
            return expiryDate; // In case of an unexpected format, return as-is
        }



        //----------------------------------------------------------------------------------------------------




        // BUTTON FUNCTIONS:
        //----------------------------------------------------------------------------------------------------

        private void back_btn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        // delete button
        private void deleteCardInfoButton_Click(object sender, EventArgs e)
        {
            if (paymentListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a card entry to delete.");
                return;
            }

            // Get the selected card's masked number (e.g., **** **** **** 1234)
            string selectedCardNumber = paymentListView.SelectedItems[0].Text;

            // Extract the last 4 digits of the card
            string lastFourDigits = selectedCardNumber.Substring(selectedCardNumber.Length - 4);

            // Prompt for confirmation before deletion
            DialogResult result = MessageBox.Show($"Are you sure you want to delete the card ending in {lastFourDigits}?",
                "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.No) return;

            // Use the UserService to delete the selected card by the last 4 digits and the userId
            bool success = _userService.DeleteCardInfo(_userId, lastFourDigits);

            if (success)
            {
                MessageBox.Show($"Card ending in {lastFourDigits} has been deleted.");
                LoadPaymentInfo(); // Reload the payment list to reflect the deletion
            }
            else
            {
                MessageBox.Show("Failed to delete the card.");
            }
        }


    }
}