namespace UniversityManagementSystem
{
    partial class CourseForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtCourseId = new TextBox();
            txtCourseName = new TextBox();
            txtSemester = new TextBox();
            txtCredit = new TextBox();
            btnInsert = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            dataGridView1 = new DataGridView();
            btnRead = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(84, 77);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 0;
            label1.Text = " Course ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(84, 129);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(98, 20);
            label2.TabIndex = 1;
            label2.Text = "Course Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(84, 177);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 2;
            label3.Text = "Semester";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(84, 226);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 3;
            label4.Text = "Credit";
            // 
            // txtCourseId
            // 
            txtCourseId.Location = new Point(204, 72);
            txtCourseId.Margin = new Padding(4, 5, 4, 5);
            txtCourseId.Name = "txtCourseId";
            txtCourseId.Size = new Size(132, 27);
            txtCourseId.TabIndex = 4;
            // 
            // txtCourseName
            // 
            txtCourseName.Location = new Point(204, 117);
            txtCourseName.Margin = new Padding(4, 5, 4, 5);
            txtCourseName.Name = "txtCourseName";
            txtCourseName.Size = new Size(132, 27);
            txtCourseName.TabIndex = 5;
            // 
            // txtSemester
            // 
            txtSemester.Location = new Point(204, 172);
            txtSemester.Margin = new Padding(4, 5, 4, 5);
            txtSemester.Name = "txtSemester";
            txtSemester.Size = new Size(132, 27);
            txtSemester.TabIndex = 6;
            // 
            // txtCredit
            // 
            txtCredit.Location = new Point(204, 222);
            txtCredit.Margin = new Padding(4, 5, 4, 5);
            txtCredit.Name = "txtCredit";
            txtCredit.Size = new Size(132, 27);
            txtCredit.TabIndex = 7;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(88, 306);
            btnInsert.Margin = new Padding(4, 5, 4, 5);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(100, 35);
            btnInsert.TabIndex = 8;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(196, 305);
            btnUpdate.Margin = new Padding(4, 5, 4, 5);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(100, 35);
            btnUpdate.TabIndex = 9;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(304, 305);
            btnDelete.Margin = new Padding(4, 5, 4, 5);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 35);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(605, 52);
            dataGridView1.Margin = new Padding(4, 5, 4, 5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(320, 231);
            dataGridView1.TabIndex = 11;
            // 
            // btnRead
            // 
            btnRead.Location = new Point(433, 305);
            btnRead.Margin = new Padding(4, 5, 4, 5);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(100, 35);
            btnRead.TabIndex = 12;
            btnRead.Text = "Read";
            btnRead.UseVisualStyleBackColor = true;
            btnRead.Click += btnRead_Click;
            // 
            // CourseForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1067, 692);
            Controls.Add(btnRead);
            Controls.Add(dataGridView1);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnInsert);
            Controls.Add(txtCredit);
            Controls.Add(txtSemester);
            Controls.Add(txtCourseName);
            Controls.Add(txtCourseId);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "CourseForm";
            Text = "CourseForm";
            Load += CourseForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCourseId;
        private System.Windows.Forms.TextBox txtCourseName;
        private System.Windows.Forms.TextBox txtSemester;
        private System.Windows.Forms.TextBox txtCredit;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnRead;
    }
}

