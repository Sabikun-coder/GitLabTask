namespace UniversityManagementSystem
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            txtUsername = new Label();
            txtPassword = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            btnLogin = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.AutoSize = true;
            txtUsername.BackColor = SystemColors.GradientActiveCaption;
            txtUsername.FlatStyle = FlatStyle.Flat;
            txtUsername.Location = new Point(380, 220);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(76, 20);
            txtUsername.TabIndex = 0;
            txtUsername.Text = "username:";
            // 
            // txtPassword
            // 
            txtPassword.AutoSize = true;
            txtPassword.BackColor = SystemColors.GradientActiveCaption;
            txtPassword.FlatStyle = FlatStyle.Flat;
            txtPassword.Location = new Point(380, 271);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(73, 20);
            txtPassword.TabIndex = 1;
            txtPassword.Text = "Password:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(495, 217);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(495, 268);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 3;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Coral;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Location = new Point(439, 413);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 29);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._1_k1hRVUmW6dQr4OfKtZCmog;
            pictureBox1.Location = new Point(421, 111);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(161, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(916, 521);
            Controls.Add(pictureBox1);
            Controls.Add(btnLogin);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Name = "LoginForm";
            Text = "Login";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtUsername;
        private Label txtPassword;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button btnLogin;
        private PictureBox pictureBox1;
    }
}
