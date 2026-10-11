using ComponentFactory.Krypton.Toolkit;
using RetroRides.Utilities;
using System;
using System.Windows.Forms;



namespace RetroRides.Forms.Client
{
    public partial class CreditCardForm : KryptonForm
    {

        public string CardNumber { get; private set; }
        public string ExpiryDate { get; private set; }
        public string CVV { get; private set; }
        public string CardName { get; private set; }
        public bool RememberCard { get; private set; }

        public CreditCardForm(string cardNumber = null, string expiryDate = null, string cvv = null, string cardName = null)
        {
            InitializeComponent();
            FormDesign.ApplyRoundedCorners(this, 12);
            SetupPlaceholderBehavior();

            PreFillFields(cardNumber, expiryDate, cvv, cardName);
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (ValidateCreditCardInfo())
            {
                SaveCardDetails();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                ShowValidationError("Please enter valid credit card details.");
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private bool ValidateCreditCardInfo()
        {
            if (!InputValidator.AreFieldsFilledWithPlaceholders(
                (cardNameTextBox, "Name on card"),
                (cardNumberTextBox, "Number on card"),
                (expiryDateTextBox, "MM/YY"),
                (cvvTextBox, "CVV")))
            {
                ShowValidationError("Please fill in all fields.");
                return false;
            }

            string cardNumber = cardNumberTextBox.Text.Trim();
            string expiryDate = expiryDateTextBox.Text.Trim();
            string cvv = cvvTextBox.Text.Trim();

            if (!InputValidator.IsCreditCardNumberValid(cardNumber))
            {
                ShowValidationError("Invalid card number. It must be between 13 and 19 digits.");
                return false;
            }

            if (!InputValidator.IsExpiryDateValid(expiryDate))
            {
                ShowValidationError("Invalid expiry date. Please use the format MM/YY and ensure the date is in the future.");
                return false;
            }

            if (!InputValidator.IsCvvValid(cvv))
            {
                ShowValidationError("Invalid CVV. It must be 3 or 4 digits.");
                return false;
            }

            return true;
        }

        private void SaveCardDetails()
        {
            CardNumber = cardNumberTextBox.Text.Trim();
            ExpiryDate = expiryDateTextBox.Text.Trim();
            CVV = cvvTextBox.Text.Trim();
            CardName = cardNameTextBox.Text.Trim();
            RememberCard = rememberCardCheckBox.Checked;
        }

        private void PreFillFields(string cardNumber, string expiryDate, string cvv, string cardName)
        {
            // Check for each field; if null or empty, call placeholder logic
            if (!string.IsNullOrEmpty(cardNumber))
            {
                cardNumberTextBox.Text = cardNumber;
            }
            else
            {
                InputValidator.HandleLeave(cardNumberTextBox, "Number on card", System.Drawing.Color.DimGray);
            }

            if (!string.IsNullOrEmpty(expiryDate))
            {
                expiryDateTextBox.Text = expiryDate;
            }
            else
            {
                InputValidator.HandleLeave(expiryDateTextBox, "MM/YY", System.Drawing.Color.DimGray);
            }

            if (!string.IsNullOrEmpty(cvv))
            {
                cvvTextBox.Text = cvv;
            }
            else
            {
                InputValidator.HandleLeave(cvvTextBox, "CVV", System.Drawing.Color.DimGray);
            }

            if (!string.IsNullOrEmpty(cardName))
            {
                cardNameTextBox.Text = cardName;
            }
            else
            {
                InputValidator.HandleLeave(cardNameTextBox, "Name on card", System.Drawing.Color.DimGray);
            }
        }

        private void SetupPlaceholderBehavior()
        {
            SetupPlaceholder(cardNameTextBox, "Name on card");
            SetupPlaceholder(cardNumberTextBox, "Number on card");
            SetupPlaceholder(expiryDateTextBox, "MM/YY");
            SetupPlaceholder(cvvTextBox, "CVV");
        }

        private void SetupPlaceholder(KryptonTextBox textBox, string placeholder)
        {
            textBox.Enter += (s, e) => InputValidator.HandleEnter(textBox, placeholder, System.Drawing.Color.Black);
            textBox.Leave += (s, e) => InputValidator.HandleLeave(textBox, placeholder, System.Drawing.Color.DimGray);
        }

        private void ShowValidationError(string message)
        {
            MessageBox.Show(message, "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


    }
}
