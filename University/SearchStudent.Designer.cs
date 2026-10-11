namespace University
{
    partial class SearchStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchStudent));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            txtReg = new TextBox();
            txtSearch = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(34, 34);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(211, 220);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.RoyalBlue;
            label1.Location = new Point(410, 53);
            label1.Name = "label1";
            label1.Size = new Size(191, 35);
            label1.TabIndex = 1;
            label1.Text = "Search Student";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(276, 146);
            label2.Name = "label2";
            label2.Size = new Size(152, 27);
            label2.TabIndex = 2;
            label2.Text = "Registration Id:";
            label2.Click += label2_Click;
            // 
            // txtReg
            // 
            txtReg.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtReg.Location = new Point(434, 140);
            txtReg.Name = "txtReg";
            txtReg.Size = new Size(294, 37);
            txtReg.TabIndex = 3;
            // 
            // txtSearch
            // 
            txtSearch.BackColor = Color.LightGray;
            txtSearch.Location = new Point(529, 183);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(112, 34);
            txtSearch.TabIndex = 4;
            txtSearch.Text = "Search";
            txtSearch.UseVisualStyleBackColor = false;
            txtSearch.Click += txtSearch_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(34, 326);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(801, 257);
            dataGridView1.TabIndex = 5;
            // 
            // SearchStudent
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(880, 615);
            Controls.Add(dataGridView1);
            Controls.Add(txtSearch);
            Controls.Add(txtReg);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "SearchStudent";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SearchStudent";
            Load += SearchStudent_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private TextBox txtReg;
        private Button txtSearch;
        private DataGridView dataGridView1;
    }
}