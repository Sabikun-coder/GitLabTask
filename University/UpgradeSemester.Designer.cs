namespace University
{
    partial class UpgradeSemester
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpgradeSemester));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            comboBoxFrom = new ComboBox();
            label2 = new Label();
            comboBoxTo = new ComboBox();
            txtUpgrade = new Button();
            txtName = new TextBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(90, 37);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(445, 222);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(199, 372);
            label1.Name = "label1";
            label1.Size = new Size(220, 30);
            label1.TabIndex = 1;
            label1.Text = "Select Old Semester";
            // 
            // comboBoxFrom
            // 
            comboBoxFrom.Font = new Font("Calibri", 11F, FontStyle.Bold);
            comboBoxFrom.FormattingEnabled = true;
            comboBoxFrom.Items.AddRange(new object[] { "1st Sem", "2nd Sem", "3rd Sem", "4th Sem", "5th Sem", "6th Sem", "7th Sem", "8th Sem" });
            comboBoxFrom.Location = new Point(156, 433);
            comboBoxFrom.Name = "comboBoxFrom";
            comboBoxFrom.Size = new Size(296, 35);
            comboBoxFrom.TabIndex = 2;
            comboBoxFrom.Text = "--Select--";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(199, 501);
            label2.Name = "label2";
            label2.Size = new Size(230, 30);
            label2.TabIndex = 3;
            label2.Text = "Select New Semester";
            // 
            // comboBoxTo
            // 
            comboBoxTo.Font = new Font("Calibri", 11F, FontStyle.Bold);
            comboBoxTo.FormattingEnabled = true;
            comboBoxTo.Items.AddRange(new object[] { "1st Sem", "2nd Sem", "3rd Sem", "4th Sem", "5th Sem", "6th Sem", "7th Sem", "8th Sem" });
            comboBoxTo.Location = new Point(156, 567);
            comboBoxTo.Name = "comboBoxTo";
            comboBoxTo.Size = new Size(296, 35);
            comboBoxTo.TabIndex = 4;
            comboBoxTo.Text = "--Select--";
            // 
            // txtUpgrade
            // 
            txtUpgrade.BackColor = SystemColors.ControlDark;
            txtUpgrade.FlatStyle = FlatStyle.System;
            txtUpgrade.Location = new Point(252, 663);
            txtUpgrade.Name = "txtUpgrade";
            txtUpgrade.Size = new Size(112, 34);
            txtUpgrade.TabIndex = 5;
            txtUpgrade.Text = "Upgrade";
            txtUpgrade.UseVisualStyleBackColor = false;
            txtUpgrade.Click += txtUpgrade_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(156, 323);
            txtName.Name = "txtName";
            txtName.Size = new Size(296, 31);
            txtName.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(252, 279);
            label3.Name = "label3";
            label3.Size = new Size(116, 30);
            label3.TabIndex = 7;
            label3.Text = "Full Name";
            // 
            // UpgradeSemester
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(634, 750);
            Controls.Add(label3);
            Controls.Add(txtName);
            Controls.Add(txtUpgrade);
            Controls.Add(comboBoxTo);
            Controls.Add(label2);
            Controls.Add(comboBoxFrom);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "UpgradeSemester";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UpgradeSemester";
            Load += UpgradeSemester_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private ComboBox comboBoxFrom;
        private Label label2;
        private ComboBox comboBoxTo;
        private Button txtUpgrade;
        private TextBox txtName;
        private Label label3;
    }
}