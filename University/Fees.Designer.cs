namespace University
{
    partial class txtFees
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(txtFees));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtReg = new TextBox();
            txtFee = new TextBox();
            txtFullName = new Label();
            txtFather = new Label();
            txtSesson = new Label();
            colorDialog1 = new ColorDialog();
            btnSubmit = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(124, 33);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(375, 233);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 11F, FontStyle.Bold);
            label1.Location = new Point(39, 309);
            label1.Name = "label1";
            label1.Size = new Size(215, 27);
            label1.TabIndex = 2;
            label1.Text = "Regestration Number:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 11F, FontStyle.Bold);
            label2.Location = new Point(84, 579);
            label2.Name = "label2";
            label2.Size = new Size(59, 27);
            label2.TabIndex = 3;
            label2.Text = "Fees:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 11F, FontStyle.Bold);
            label3.Location = new Point(84, 514);
            label3.Name = "label3";
            label3.Size = new Size(86, 27);
            label3.TabIndex = 4;
            label3.Text = "Session:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 11F, FontStyle.Bold);
            label4.Location = new Point(84, 442);
            label4.Name = "label4";
            label4.Size = new Size(136, 27);
            label4.TabIndex = 5;
            label4.Text = "Father Name:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 11F, FontStyle.Bold);
            label5.Location = new Point(84, 381);
            label5.Name = "label5";
            label5.Size = new Size(109, 27);
            label5.TabIndex = 6;
            label5.Text = "Full Name:";
            // 
            // txtReg
            // 
            txtReg.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            txtReg.Location = new Point(290, 309);
            txtReg.Name = "txtReg";
            txtReg.Size = new Size(209, 34);
            txtReg.TabIndex = 7;
            txtReg.TextChanged += txtReg_TextChanged;
            // 
            // txtFee
            // 
            txtFee.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            txtFee.Location = new Point(290, 575);
            txtFee.Name = "txtFee";
            txtFee.Size = new Size(209, 34);
            txtFee.TabIndex = 8;
            // 
            // txtFullName
            // 
            txtFullName.AutoSize = true;
            txtFullName.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            txtFullName.Location = new Point(290, 383);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(52, 28);
            txtFullName.TabIndex = 9;
            txtFullName.Text = "_____";
            // 
            // txtFather
            // 
            txtFather.AutoSize = true;
            txtFather.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            txtFather.Location = new Point(290, 444);
            txtFather.Name = "txtFather";
            txtFather.Size = new Size(52, 28);
            txtFather.TabIndex = 10;
            txtFather.Text = "_____";
            // 
            // txtSesson
            // 
            txtSesson.AutoSize = true;
            txtSesson.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            txtSesson.Location = new Point(290, 514);
            txtSesson.Name = "txtSesson";
            txtSesson.Size = new Size(52, 28);
            txtSesson.TabIndex = 11;
            txtSesson.Text = "_____";
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.LightGray;
            btnSubmit.Location = new Point(253, 674);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(112, 34);
            btnSubmit.TabIndex = 12;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // txtFees
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(634, 750);
            Controls.Add(btnSubmit);
            Controls.Add(txtSesson);
            Controls.Add(txtFather);
            Controls.Add(txtFullName);
            Controls.Add(txtFee);
            Controls.Add(txtReg);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "txtFees";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Fees";
            Load += txtFees_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtReg;
        private TextBox txtFee;
        private Label txtFullName;
        private Label txtFather;
        private Label txtSesson;
        private ColorDialog colorDialog1;
        private Button btnSubmit;
    }
}