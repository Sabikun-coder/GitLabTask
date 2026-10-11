namespace UniversityManagementSystem
{
    partial class TeacherForm
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
            lblName = new Label();
            lblDepartment = new Label();
            lblCourse = new Label();
            lblAddress = new Label();
            btnSave = new Button();
            btnRead = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            textName = new TextBox();
            textAddress = new TextBox();
            textDept = new ComboBox();
            textCourse = new ComboBox();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            textId = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(54, 129);
            lblName.Margin = new Padding(2, 0, 2, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(49, 20);
            lblName.TabIndex = 0;
            lblName.Text = "Name";
            // 
            // lblDepartment
            // 
            lblDepartment.AutoSize = true;
            lblDepartment.Location = new Point(54, 182);
            lblDepartment.Margin = new Padding(2, 0, 2, 0);
            lblDepartment.Name = "lblDepartment";
            lblDepartment.Size = new Size(89, 20);
            lblDepartment.TabIndex = 1;
            lblDepartment.Text = "Department";
            // 
            // lblCourse
            // 
            lblCourse.AutoSize = true;
            lblCourse.Location = new Point(54, 235);
            lblCourse.Margin = new Padding(2, 0, 2, 0);
            lblCourse.Name = "lblCourse";
            lblCourse.Size = new Size(54, 20);
            lblCourse.TabIndex = 2;
            lblCourse.Text = "Course";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(54, 292);
            lblAddress.Margin = new Padding(2, 0, 2, 0);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(62, 20);
            lblAddress.TabIndex = 3;
            lblAddress.Text = "Address";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.ForestGreen;
            btnSave.Location = new Point(40, 386);
            btnSave.Margin = new Padding(2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(90, 27);
            btnSave.TabIndex = 4;
            btnSave.Text = "Create";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnRead
            // 
            btnRead.BackColor = Color.DodgerBlue;
            btnRead.Location = new Point(159, 386);
            btnRead.Margin = new Padding(2);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(90, 27);
            btnRead.TabIndex = 5;
            btnRead.Text = "Read";
            btnRead.UseVisualStyleBackColor = false;
            btnRead.Click += btnRead_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Yellow;
            btnUpdate.Location = new Point(287, 386);
            btnUpdate.Margin = new Padding(2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(90, 27);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.IndianRed;
            btnDelete.Location = new Point(406, 386);
            btnDelete.Margin = new Padding(2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(90, 27);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // textName
            // 
            textName.Location = new Point(159, 129);
            textName.Margin = new Padding(2);
            textName.Name = "textName";
            textName.Size = new Size(146, 27);
            textName.TabIndex = 8;
            // 
            // textAddress
            // 
            textAddress.Location = new Point(159, 292);
            textAddress.Margin = new Padding(2);
            textAddress.Multiline = true;
            textAddress.Name = "textAddress";
            textAddress.Size = new Size(146, 26);
            textAddress.TabIndex = 9;
            // 
            // textDept
            // 
            textDept.FormattingEnabled = true;
            textDept.Items.AddRange(new object[] { "Computer Science", "Software Engineering", "Information Technology", "Electrical Engineering", "Civil Engineering", "Mechanical Engineering", "Business Administration", "Accounting", "Finance", "Marketing", "English", "Mathematics", "Physics", "Chemistry", "Biology" });
            textDept.Location = new Point(159, 179);
            textDept.Margin = new Padding(2);
            textDept.Name = "textDept";
            textDept.Size = new Size(146, 28);
            textDept.TabIndex = 10;
            // 
            // textCourse
            // 
            textCourse.FormattingEnabled = true;
            textCourse.Items.AddRange(new object[] { "Math", "Science ", "", "", "History ", "", "", "English", "", "", "Biology", "", "", "Physics", "", "", "Chemistry" });
            textCourse.Location = new Point(159, 235);
            textCourse.Margin = new Padding(2);
            textCourse.Name = "textCourse";
            textCourse.Size = new Size(146, 28);
            textCourse.TabIndex = 11;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(490, 114);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(404, 241);
            dataGridView1.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 94);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 14;
            label1.Text = "TeacherID";
            // 
            // textId
            // 
            textId.Location = new Point(159, 94);
            textId.Name = "textId";
            textId.Size = new Size(146, 27);
            textId.TabIndex = 15;
            // 
            // TeacherForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(912, 469);
            Controls.Add(textId);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(textCourse);
            Controls.Add(textDept);
            Controls.Add(textAddress);
            Controls.Add(textName);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnRead);
            Controls.Add(btnSave);
            Controls.Add(lblAddress);
            Controls.Add(lblCourse);
            Controls.Add(lblDepartment);
            Controls.Add(lblName);
            Margin = new Padding(2);
            Name = "TeacherForm";
            Text = "TeacherForm";
            Load += TeacherForm_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Label lblDepartment;
        private Label lblCourse;
        private Label lblAddress;
        private Button btnSave;
        private Button btnRead;
        private Button btnUpdate;
        private Button btnDelete;
        private TextBox textName;
        private TextBox textAddress;
        private ComboBox textDept;
        private ComboBox textCourse;
        private DataGridView dataGridView1;
        private Label label1;
        private TextBox textId;
    }
}
