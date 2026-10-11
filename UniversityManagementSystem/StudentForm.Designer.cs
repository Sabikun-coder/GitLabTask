namespace UniversityManagementSystem
{
    partial class StudentForm
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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            nameInputBox = new TextBox();
            cmbDepartment = new ComboBox();
            cmbSemester = new ComboBox();
            phoneInputBox = new TextBox();
            btnCreate = new Button();
            btnUpdate = new Button();
            btnRead = new Button();
            btnDelete = new Button();
            dgvStudent = new DataGridView();
            label7 = new Label();
            cmbGender = new ComboBox();
            label8 = new Label();
            label2 = new Label();
            studentIDInputBox = new TextBox();
            label9 = new Label();
            textEmail = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvStudent).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(277, 11);
            label1.Name = "label1";
            label1.Size = new Size(257, 29);
            label1.TabIndex = 0;
            label1.Text = "Student's Information";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(55, 122);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 3;
            label3.Text = "Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(55, 171);
            label4.Name = "label4";
            label4.Size = new Size(107, 20);
            label4.TabIndex = 4;
            label4.Text = "Department";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(55, 225);
            label5.Name = "label5";
            label5.Size = new Size(89, 20);
            label5.TabIndex = 5;
            label5.Text = "Semester";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(55, 276);
            label6.Name = "label6";
            label6.Size = new Size(61, 20);
            label6.TabIndex = 6;
            label6.Text = "Phone";
            // 
            // nameInputBox
            // 
            nameInputBox.Location = new Point(212, 122);
            nameInputBox.Margin = new Padding(3, 4, 3, 4);
            nameInputBox.Name = "nameInputBox";
            nameInputBox.Size = new Size(182, 27);
            nameInputBox.TabIndex = 7;
            nameInputBox.TextChanged += textName_TextChanged;
            // 
            // cmbDepartment
            // 
            cmbDepartment.FormattingEnabled = true;
            cmbDepartment.Items.AddRange(new object[] { "CSE", "EEE", "IPE", "BBA" });
            cmbDepartment.Location = new Point(212, 171);
            cmbDepartment.Margin = new Padding(3, 4, 3, 4);
            cmbDepartment.Name = "cmbDepartment";
            cmbDepartment.Size = new Size(182, 28);
            cmbDepartment.TabIndex = 8;
            cmbDepartment.SelectedIndexChanged += cmbDepartment_SelectedIndexChanged;
            // 
            // cmbSemester
            // 
            cmbSemester.FormattingEnabled = true;
            cmbSemester.Items.AddRange(new object[] { "1st Semester", "2nd Semester", "3rd Semester", "4th Semester", "5th Semester", "6th Semester", "7th Semester", "8th Semester", "9th Semester", "10th Semester", "11th Semester", "12th Semester" });
            cmbSemester.Location = new Point(212, 225);
            cmbSemester.Margin = new Padding(3, 4, 3, 4);
            cmbSemester.Name = "cmbSemester";
            cmbSemester.Size = new Size(182, 28);
            cmbSemester.TabIndex = 9;
            // 
            // phoneInputBox
            // 
            phoneInputBox.Location = new Point(212, 276);
            phoneInputBox.Margin = new Padding(3, 4, 3, 4);
            phoneInputBox.Name = "phoneInputBox";
            phoneInputBox.Size = new Size(182, 27);
            phoneInputBox.TabIndex = 10;
            // 
            // btnCreate
            // 
            btnCreate.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreate.Location = new Point(41, 430);
            btnCreate.Margin = new Padding(3, 4, 3, 4);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(75, 29);
            btnCreate.TabIndex = 11;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(165, 430);
            btnUpdate.Margin = new Padding(3, 4, 3, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 29);
            btnUpdate.TabIndex = 12;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnRead
            // 
            btnRead.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRead.Location = new Point(268, 430);
            btnRead.Margin = new Padding(3, 4, 3, 4);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(75, 29);
            btnRead.TabIndex = 13;
            btnRead.Text = "Read";
            btnRead.UseVisualStyleBackColor = true;
            btnRead.Click += btnRead_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = SystemColors.ActiveCaptionText;
            btnDelete.Location = new Point(374, 430);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 29);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dgvStudent
            // 
            dgvStudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudent.Location = new Point(481, 110);
            dgvStudent.Margin = new Padding(3, 4, 3, 4);
            dgvStudent.Name = "dgvStudent";
            dgvStudent.RowHeadersWidth = 51;
            dgvStudent.RowTemplate.Height = 24;
            dgvStudent.Size = new Size(282, 304);
            dgvStudent.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(67, 338);
            label7.Name = "label7";
            label7.Size = new Size(13, 20);
            label7.TabIndex = 16;
            label7.Text = " ";
            // 
            // cmbGender
            // 
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "Male", "Female" });
            cmbGender.Location = new Point(212, 334);
            cmbGender.Margin = new Padding(3, 4, 3, 4);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(182, 28);
            cmbGender.TabIndex = 17;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(56, 338);
            label8.Name = "label8";
            label8.Size = new Size(63, 18);
            label8.TabIndex = 18;
            label8.Text = "Gender";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(55, 82);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 19;
            label2.Text = "StudentId";
            // 
            // studentIDInputBox
            // 
            studentIDInputBox.Location = new Point(212, 79);
            studentIDInputBox.Name = "studentIDInputBox";
            studentIDInputBox.Size = new Size(182, 27);
            studentIDInputBox.TabIndex = 20;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(62, 382);
            label9.Name = "label9";
            label9.Size = new Size(46, 20);
            label9.TabIndex = 21;
            label9.Text = "Email";
            // 
            // textEmail
            // 
            textEmail.Location = new Point(210, 384);
            textEmail.Name = "textEmail";
            textEmail.Size = new Size(184, 27);
            textEmail.TabIndex = 22;
            textEmail.TextChanged += textBox1_TextChanged;
            // 
            // StudentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 562);
            Controls.Add(textEmail);
            Controls.Add(label9);
            Controls.Add(studentIDInputBox);
            Controls.Add(label2);
            Controls.Add(label8);
            Controls.Add(cmbGender);
            Controls.Add(label7);
            Controls.Add(dgvStudent);
            Controls.Add(btnDelete);
            Controls.Add(btnRead);
            Controls.Add(btnUpdate);
            Controls.Add(btnCreate);
            Controls.Add(phoneInputBox);
            Controls.Add(cmbSemester);
            Controls.Add(cmbDepartment);
            Controls.Add(nameInputBox);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "StudentForm";
            Text = "StudentForm";
            ((System.ComponentModel.ISupportInitialize)dgvStudent).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox nameInputBox;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.ComboBox cmbSemester;
        private System.Windows.Forms.TextBox phoneInputBox;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvStudent;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.Label label8;
        private Label label2;
        private TextBox studentIDInputBox;
        private Label label9;
        private TextBox textEmail;
    }
}

