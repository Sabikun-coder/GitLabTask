using ComponentFactory.Krypton.Toolkit;
using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace RetroRides.Utilities
{
    public static class InputValidator
    {
        // Check if any of the provided TextBoxes are empty or contain placeholder text
        //---------------------------------------------------------------------------------------------------
        public static bool AreFieldsFilledWithPlaceholders(params (KryptonTextBox TextBox, string Placeholder)[] textboxes)
        {
            foreach (var (textbox, placeholder) in textboxes)
            {
                if (IsFieldEmptyOrPlaceholder(textbox, placeholder))
                {
                    return false;  // Return false if any field is empty or contains placeholder text
                }
            }
            return true;  // Return true if all fields are properly filled
        }
        //---------------------------------------------------------------------------------------------------






        // Check if two password fields match, considering placeholders
        //---------------------------------------------------------------------------------------------------
        public static bool ArePasswordsMatching(KryptonTextBox password1, string placeholder1, KryptonTextBox password2, string placeholder2)
        {
            return password1.Text == password2.Text
                   && !IsFieldEmptyOrPlaceholder(password1, placeholder1)
                   && !IsFieldEmptyOrPlaceholder(password2, placeholder2);
        }
        //---------------------------------------------------------------------------------------------------





        // Helper method to check if the field contains placeholder text or is empty
        //---------------------------------------------------------------------------------------------------
        public static bool IsFieldEmptyOrPlaceholder(KryptonTextBox textbox, string placeholder)
        {
            return textbox.ForeColor == Color.DimGray || textbox.Text == placeholder || string.IsNullOrWhiteSpace(textbox.Text);
        }
        //---------------------------------------------------------------------------------------------------






        // Method to validate if the phone number contains only digits
        //---------------------------------------------------------------------------------------------------
        public static bool IsPhoneNumberValid(string phoneNumber)
        {
            // Regex to allow only digits, optional + for country codes, and optional length validation (example: 7-15 digits)
            string phonePattern = @"^[0-9]{7,15}$";  // Adjust length as needed

            // Use Regex to match the pattern
            return Regex.IsMatch(phoneNumber, phonePattern);
        }
        //---------------------------------------------------------------------------------------------------







        // Toggle password visibility for multiple password boxes (e.g., password and confirm password)
        //---------------------------------------------------------------------------------------------------
        public static void TogglePasswordVisibility(CheckBox checkBox, KryptonTextBox passwordBox, string Placeholder, KryptonTextBox confirmPasswordBox, string CPlaceholder)
        {
            // Toggle for the first password box
            TogglePasswordVisibility(checkBox, passwordBox, Placeholder);

            // Toggle for the confirm password box
            TogglePasswordVisibility(checkBox, confirmPasswordBox, CPlaceholder);
        }

        // Toggle password visibility for a single password box
        public static void TogglePasswordVisibility(CheckBox checkBox, KryptonTextBox passwordBox, string placeholder)
        {
            if (checkBox.Checked && passwordBox.Text != placeholder)
            {
                passwordBox.PasswordChar = '\0';  // Show password
            }
            else if (!string.IsNullOrWhiteSpace(passwordBox.Text) && passwordBox.Text != placeholder)
            {
                passwordBox.PasswordChar = '*';  // Mask password
            }
        }

        //---------------------------------------------------------------------------------------------------








        // Overload for KryptonTextBox (already exists)
        //---------------------------------------------------------------------------------------------------
        public static void HandleEnter(KryptonTextBox textBox, string placeholder, Color normalTextColor)
        {
            if (textBox.Text == placeholder)
            {
                textBox.Text = "";
                textBox.ForeColor = normalTextColor; // Set to normal text color
            }
        }

        public static void HandleLeave(KryptonTextBox textBox, string placeholder, Color placeholderColor)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = placeholder;
                textBox.ForeColor = placeholderColor; // Set to placeholder color
            }
        }

        // New overload for KryptonRichTextBox
        public static void HandleEnter(KryptonRichTextBox richTextBox, string placeholder, Color normalTextColor)
        {
            if (richTextBox.Text == placeholder)
            {
                richTextBox.Text = "";
                richTextBox.ForeColor = normalTextColor; // Set to normal text color
            }
        }

        public static void HandleLeave(KryptonRichTextBox richTextBox, string placeholder, Color placeholderColor)
        {
            if (string.IsNullOrWhiteSpace(richTextBox.Text))
            {
                richTextBox.Text = placeholder;
                richTextBox.ForeColor = placeholderColor; // Set to placeholder color
            }
        }

        // Method to handle password masking when entering or leaving a password textbox
        public static void HandlePasswordEnter(KryptonTextBox passwordBox, string placeholder, CheckBox showPasswordCheckBox)
        {
            if (passwordBox.Text == placeholder)
            {
                passwordBox.Text = "";  // Clear the placeholder
                passwordBox.ForeColor = Color.Black;  // Normal text color
                if (!showPasswordCheckBox.Checked)
                {
                    passwordBox.PasswordChar = '*';  // Mask password
                }
            }
        }

        public static void HandlePasswordLeave(KryptonTextBox passwordBox, string placeholder, CheckBox showPasswordCheckBox)
        {
            if (string.IsNullOrWhiteSpace(passwordBox.Text))
            {
                passwordBox.Text = placeholder;  // Restore placeholder
                passwordBox.ForeColor = Color.Gray;  // Placeholder text color
                passwordBox.PasswordChar = '\0';  // Disable password masking for placeholder
            }
        }
        //---------------------------------------------------------------------------------------------------









        // CREDIT CARD VALIDATOR:
        //---------------------------------------------------------------------------------------------------

        // Validate if the credit card number contains only digits and has a valid length (usually 13-19 digits)
        public static bool IsCreditCardNumberValid(string cardNumber)
        {
            // Allow only digits, and the card number should be between 13 and 19 digits
            string cardPattern = @"^\d{13,19}$";
            return Regex.IsMatch(cardNumber, cardPattern);
        }

        // Validate the expiry date in the format MM/YY
        public static bool IsExpiryDateValid(string expiryDate)
        {
            string expiryPattern = @"^(0[1-9]|1[0-2])\/?([0-9]{2})$"; // Matches MM/YY format
            if (!Regex.IsMatch(expiryDate, expiryPattern))
                return false;

            // Additional check: Ensure expiry date is in the future
            var parts = expiryDate.Split('/');
            if (parts.Length == 2 && int.TryParse(parts[0], out int month) && int.TryParse(parts[1], out int year))
            {
                year += 2000; // Convert YY to YYYY
                var expiry = new DateTime(year, month, 1).AddMonths(1).AddDays(-1); // Last day of expiry month
                return DateTime.Now <= expiry; // Valid if current date is before the expiry date
            }

            return false;
        }

        // Validate CVV (3 digits for most cards, 4 digits for Amex)
        public static bool IsCvvValid(string cvv)
        {
            string cvvPattern = @"^\d{3,4}$";
            return Regex.IsMatch(cvv, cvvPattern);
        }
        //---------------------------------------------------------------------------------------------------
    }
}
