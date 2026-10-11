namespace RetroRides.Forms.Client
{
    partial class CreditCardForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreditCardForm));
            this.submitButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.cardNameTextBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.cardNumberTextBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.expiryDateTextBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.cvvTextBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.nameLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.dateLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.numberLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cvvLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.rememberCardCheckBox = new System.Windows.Forms.CheckBox();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(633, 354);
            this.submitButton.Name = "submitButton";
            this.submitButton.OverrideDefault.Back.Color1 = System.Drawing.Color.White;
            this.submitButton.OverrideDefault.Back.Color2 = System.Drawing.Color.MistyRose;
            this.submitButton.OverrideDefault.Back.ColorAngle = 45F;
            this.submitButton.OverrideDefault.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.submitButton.OverrideDefault.Border.Color1 = System.Drawing.Color.Salmon;
            this.submitButton.OverrideDefault.Border.Color2 = System.Drawing.Color.OrangeRed;
            this.submitButton.OverrideDefault.Border.ColorAngle = 45F;
            this.submitButton.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.submitButton.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.submitButton.OverrideDefault.Border.Rounding = 10;
            this.submitButton.OverrideDefault.Border.Width = 1;
            this.submitButton.OverrideDefault.Content.ShortText.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias;
            this.submitButton.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.submitButton.Size = new System.Drawing.Size(89, 40);
            this.submitButton.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.submitButton.StateCommon.Back.Color2 = System.Drawing.Color.MistyRose;
            this.submitButton.StateCommon.Back.ColorAngle = 45F;
            this.submitButton.StateCommon.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.submitButton.StateCommon.Border.Color1 = System.Drawing.Color.Salmon;
            this.submitButton.StateCommon.Border.Color2 = System.Drawing.Color.OrangeRed;
            this.submitButton.StateCommon.Border.ColorAngle = 45F;
            this.submitButton.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.submitButton.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.submitButton.StateCommon.Border.Rounding = 10;
            this.submitButton.StateCommon.Border.Width = 1;
            this.submitButton.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.submitButton.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitButton.StateCommon.Content.ShortText.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias;
            this.submitButton.StatePressed.Back.Color1 = System.Drawing.Color.Maroon;
            this.submitButton.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.submitButton.StatePressed.Back.ColorAngle = 135F;
            this.submitButton.StatePressed.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.submitButton.StatePressed.Border.Color1 = System.Drawing.Color.Salmon;
            this.submitButton.StatePressed.Border.Color2 = System.Drawing.Color.Maroon;
            this.submitButton.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.submitButton.StatePressed.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.submitButton.StatePressed.Border.Rounding = 10;
            this.submitButton.StatePressed.Border.Width = 1;
            this.submitButton.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.submitButton.StatePressed.Content.ShortText.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias;
            this.submitButton.StateTracking.Back.Color1 = System.Drawing.Color.Red;
            this.submitButton.StateTracking.Back.Color2 = System.Drawing.Color.White;
            this.submitButton.StateTracking.Back.ColorAngle = 45F;
            this.submitButton.StateTracking.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.submitButton.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.submitButton.StateTracking.Border.Color2 = System.Drawing.Color.White;
            this.submitButton.StateTracking.Border.ColorAngle = 45F;
            this.submitButton.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.submitButton.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.submitButton.StateTracking.Border.Rounding = 10;
            this.submitButton.StateTracking.Border.Width = 1;
            this.submitButton.StateTracking.Content.ShortText.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias;
            this.submitButton.TabIndex = 1;
            this.submitButton.Values.Text = "Submit";
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // cardNameTextBox
            // 
            this.cardNameTextBox.Location = new System.Drawing.Point(422, 206);
            this.cardNameTextBox.Name = "cardNameTextBox";
            this.cardNameTextBox.Size = new System.Drawing.Size(171, 37);
            this.cardNameTextBox.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.cardNameTextBox.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cardNameTextBox.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cardNameTextBox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cardNameTextBox.StateCommon.Border.Rounding = 20;
            this.cardNameTextBox.StateCommon.Border.Width = 1;
            this.cardNameTextBox.StateCommon.Content.Color1 = System.Drawing.Color.DimGray;
            this.cardNameTextBox.StateCommon.Content.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardNameTextBox.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.cardNameTextBox.TabIndex = 5;
            this.cardNameTextBox.Text = "Name on card";
            // 
            // cardNumberTextBox
            // 
            this.cardNumberTextBox.Location = new System.Drawing.Point(423, 294);
            this.cardNumberTextBox.Name = "cardNumberTextBox";
            this.cardNumberTextBox.Size = new System.Drawing.Size(170, 37);
            this.cardNumberTextBox.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.cardNumberTextBox.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cardNumberTextBox.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cardNumberTextBox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cardNumberTextBox.StateCommon.Border.Rounding = 20;
            this.cardNumberTextBox.StateCommon.Border.Width = 1;
            this.cardNumberTextBox.StateCommon.Content.Color1 = System.Drawing.Color.DimGray;
            this.cardNumberTextBox.StateCommon.Content.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardNumberTextBox.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.cardNumberTextBox.TabIndex = 6;
            this.cardNumberTextBox.Text = "Number on card";
            // 
            // expiryDateTextBox
            // 
            this.expiryDateTextBox.Location = new System.Drawing.Point(613, 206);
            this.expiryDateTextBox.Name = "expiryDateTextBox";
            this.expiryDateTextBox.Size = new System.Drawing.Size(138, 37);
            this.expiryDateTextBox.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.expiryDateTextBox.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.expiryDateTextBox.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.expiryDateTextBox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.expiryDateTextBox.StateCommon.Border.Rounding = 20;
            this.expiryDateTextBox.StateCommon.Border.Width = 1;
            this.expiryDateTextBox.StateCommon.Content.Color1 = System.Drawing.Color.DimGray;
            this.expiryDateTextBox.StateCommon.Content.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expiryDateTextBox.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.expiryDateTextBox.TabIndex = 7;
            this.expiryDateTextBox.Text = "MM/YY";
            // 
            // cvvTextBox
            // 
            this.cvvTextBox.Location = new System.Drawing.Point(613, 294);
            this.cvvTextBox.Name = "cvvTextBox";
            this.cvvTextBox.Size = new System.Drawing.Size(138, 37);
            this.cvvTextBox.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.cvvTextBox.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cvvTextBox.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cvvTextBox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cvvTextBox.StateCommon.Border.Rounding = 20;
            this.cvvTextBox.StateCommon.Border.Width = 1;
            this.cvvTextBox.StateCommon.Content.Color1 = System.Drawing.Color.DimGray;
            this.cvvTextBox.StateCommon.Content.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cvvTextBox.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.cvvTextBox.TabIndex = 8;
            this.cvvTextBox.Text = "CVV";
            // 
            // nameLabel
            // 
            this.nameLabel.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.nameLabel.Location = new System.Drawing.Point(422, 182);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.nameLabel.Size = new System.Drawing.Size(54, 23);
            this.nameLabel.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.nameLabel.StateCommon.ShortText.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.TabIndex = 9;
            this.nameLabel.Values.Text = "Name*";
            // 
            // dateLabel
            // 
            this.dateLabel.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.dateLabel.Location = new System.Drawing.Point(613, 182);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.dateLabel.Size = new System.Drawing.Size(84, 23);
            this.dateLabel.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.dateLabel.StateCommon.ShortText.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.TabIndex = 9;
            this.dateLabel.Values.Text = "Expiry Date*";
            // 
            // numberLabel
            // 
            this.numberLabel.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.numberLabel.Location = new System.Drawing.Point(422, 271);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.numberLabel.Size = new System.Drawing.Size(100, 23);
            this.numberLabel.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.numberLabel.StateCommon.ShortText.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberLabel.TabIndex = 9;
            this.numberLabel.Values.Text = "Card number*";
            // 
            // cvvLabel
            // 
            this.cvvLabel.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.cvvLabel.Location = new System.Drawing.Point(613, 271);
            this.cvvLabel.Name = "cvvLabel";
            this.cvvLabel.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.cvvLabel.Size = new System.Drawing.Size(43, 23);
            this.cvvLabel.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.cvvLabel.StateCommon.ShortText.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cvvLabel.TabIndex = 9;
            this.cvvLabel.Values.Text = "CVV*";
            // 
            // rememberCardCheckBox
            // 
            this.rememberCardCheckBox.AutoSize = true;
            this.rememberCardCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.rememberCardCheckBox.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rememberCardCheckBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rememberCardCheckBox.Location = new System.Drawing.Point(423, 354);
            this.rememberCardCheckBox.Name = "rememberCardCheckBox";
            this.rememberCardCheckBox.Size = new System.Drawing.Size(123, 26);
            this.rememberCardCheckBox.TabIndex = 15;
            this.rememberCardCheckBox.Text = "Remember card";
            this.rememberCardCheckBox.UseVisualStyleBackColor = false;
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Transparent;
            this.backButton.BackgroundImage = global::RetroRides.Properties.Resources.Close_Window;
            this.backButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.backButton.FlatAppearance.BorderSize = 0;
            this.backButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.ForeColor = System.Drawing.Color.Transparent;
            this.backButton.Location = new System.Drawing.Point(745, 12);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(27, 36);
            this.backButton.TabIndex = 37;
            this.backButton.TabStop = false;
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // CreditCardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RetroRides.Properties.Resources.CreditCardPage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.rememberCardCheckBox);
            this.Controls.Add(this.cvvLabel);
            this.Controls.Add(this.numberLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.cvvTextBox);
            this.Controls.Add(this.expiryDateTextBox);
            this.Controls.Add(this.cardNumberTextBox);
            this.Controls.Add(this.cardNameTextBox);
            this.Controls.Add(this.submitButton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreditCardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreditCardForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonButton submitButton;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox cardNameTextBox;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox cardNumberTextBox;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox expiryDateTextBox;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox cvvTextBox;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel nameLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel dateLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel numberLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel cvvLabel;
        private System.Windows.Forms.CheckBox rememberCardCheckBox;
        private System.Windows.Forms.Button backButton;
    }
}