namespace University
{
    partial class Student
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Student));
            menuStrip1 = new MenuStrip();
            admissionToolStripMenuItem = new ToolStripMenuItem();
            newAdmissionToolStripMenuItem = new ToolStripMenuItem();
            upgradeSemesterToolStripMenuItem = new ToolStripMenuItem();
            feesToolStripMenuItem = new ToolStripMenuItem();
            studentDetailsToolStripMenuItem = new ToolStripMenuItem();
            searchStudentToolStripMenuItem = new ToolStripMenuItem();
            individualDetailsToolStripMenuItem = new ToolStripMenuItem();
            teacherToolStripMenuItem = new ToolStripMenuItem();
            addTeacherInformationToolStripMenuItem = new ToolStripMenuItem();
            searchToolStripMenuItem = new ToolStripMenuItem();
            removeStudentToolStripMenuItem = new ToolStripMenuItem();
            aboutUsToolBar = new ToolStripMenuItem();
            exitSystemToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            contextMenuStrip1 = new ContextMenuStrip(components);
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { admissionToolStripMenuItem, feesToolStripMenuItem, studentDetailsToolStripMenuItem, teacherToolStripMenuItem, removeStudentToolStripMenuItem, aboutUsToolBar, exitSystemToolStripMenuItem, toolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(1069, 68);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // admissionToolStripMenuItem
            // 
            admissionToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newAdmissionToolStripMenuItem, upgradeSemesterToolStripMenuItem });
            admissionToolStripMenuItem.Image = (Image)resources.GetObject("admissionToolStripMenuItem.Image");
            admissionToolStripMenuItem.ImageAlign = ContentAlignment.MiddleLeft;
            admissionToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            admissionToolStripMenuItem.Name = "admissionToolStripMenuItem";
            admissionToolStripMenuItem.Size = new Size(152, 64);
            admissionToolStripMenuItem.Text = "Admission";
            // 
            // newAdmissionToolStripMenuItem
            // 
            newAdmissionToolStripMenuItem.Name = "newAdmissionToolStripMenuItem";
            newAdmissionToolStripMenuItem.Size = new Size(224, 26);
            newAdmissionToolStripMenuItem.Text = "New Admission";
            newAdmissionToolStripMenuItem.Click += newAdmissionToolStripMenuItem_Click;
            // 
            // upgradeSemesterToolStripMenuItem
            // 
            upgradeSemesterToolStripMenuItem.Name = "upgradeSemesterToolStripMenuItem";
            upgradeSemesterToolStripMenuItem.Size = new Size(224, 26);
            upgradeSemesterToolStripMenuItem.Text = "Upgrade Semester";
            upgradeSemesterToolStripMenuItem.Click += upgradeSemesterToolStripMenuItem_Click;
            // 
            // feesToolStripMenuItem
            // 
            feesToolStripMenuItem.Image = (Image)resources.GetObject("feesToolStripMenuItem.Image");
            feesToolStripMenuItem.ImageAlign = ContentAlignment.MiddleLeft;
            feesToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            feesToolStripMenuItem.Name = "feesToolStripMenuItem";
            feesToolStripMenuItem.Size = new Size(112, 64);
            feesToolStripMenuItem.Text = "Fees";
            feesToolStripMenuItem.Click += feesToolStripMenuItem_Click;
            // 
            // studentDetailsToolStripMenuItem
            // 
            studentDetailsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { searchStudentToolStripMenuItem, individualDetailsToolStripMenuItem });
            studentDetailsToolStripMenuItem.Image = (Image)resources.GetObject("studentDetailsToolStripMenuItem.Image");
            studentDetailsToolStripMenuItem.ImageAlign = ContentAlignment.MiddleLeft;
            studentDetailsToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            studentDetailsToolStripMenuItem.Name = "studentDetailsToolStripMenuItem";
            studentDetailsToolStripMenuItem.Size = new Size(184, 64);
            studentDetailsToolStripMenuItem.Text = "Student Details";
            // 
            // searchStudentToolStripMenuItem
            // 
            searchStudentToolStripMenuItem.Name = "searchStudentToolStripMenuItem";
            searchStudentToolStripMenuItem.Size = new Size(224, 26);
            searchStudentToolStripMenuItem.Text = "Search Student";
            searchStudentToolStripMenuItem.Click += searchStudentToolStripMenuItem_Click;
            // 
            // individualDetailsToolStripMenuItem
            // 
            individualDetailsToolStripMenuItem.Name = "individualDetailsToolStripMenuItem";
            individualDetailsToolStripMenuItem.Size = new Size(224, 26);
            individualDetailsToolStripMenuItem.Text = "Individual Details";
            individualDetailsToolStripMenuItem.Click += individualDetailsToolStripMenuItem_Click;
            // 
            // teacherToolStripMenuItem
            // 
            teacherToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addTeacherInformationToolStripMenuItem, searchToolStripMenuItem });
            teacherToolStripMenuItem.Image = (Image)resources.GetObject("teacherToolStripMenuItem.Image");
            teacherToolStripMenuItem.ImageAlign = ContentAlignment.MiddleLeft;
            teacherToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            teacherToolStripMenuItem.Name = "teacherToolStripMenuItem";
            teacherToolStripMenuItem.Size = new Size(140, 64);
            teacherToolStripMenuItem.Text = "Teachers";
            teacherToolStripMenuItem.Click += teacherToolStripMenuItem_Click;
            // 
            // addTeacherInformationToolStripMenuItem
            // 
            addTeacherInformationToolStripMenuItem.Name = "addTeacherInformationToolStripMenuItem";
            addTeacherInformationToolStripMenuItem.Size = new Size(257, 26);
            addTeacherInformationToolStripMenuItem.Text = "Add Teacher information";
            addTeacherInformationToolStripMenuItem.Click += addTeacherInformationToolStripMenuItem_Click;
            // 
            // searchToolStripMenuItem
            // 
            searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            searchToolStripMenuItem.Size = new Size(257, 26);
            searchToolStripMenuItem.Text = "Search";
            searchToolStripMenuItem.Click += searchToolStripMenuItem_Click;
            // 
            // removeStudentToolStripMenuItem
            // 
            removeStudentToolStripMenuItem.Image = (Image)resources.GetObject("removeStudentToolStripMenuItem.Image");
            removeStudentToolStripMenuItem.ImageAlign = ContentAlignment.MiddleLeft;
            removeStudentToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            removeStudentToolStripMenuItem.Name = "removeStudentToolStripMenuItem";
            removeStudentToolStripMenuItem.Size = new Size(192, 64);
            removeStudentToolStripMenuItem.Text = "Remove Student";
            removeStudentToolStripMenuItem.Click += removeStudentToolStripMenuItem_Click;
            // 
            // aboutUsToolBar
            // 
            aboutUsToolBar.Image = (Image)resources.GetObject("aboutUsToolBar.Image");
            aboutUsToolBar.ImageAlign = ContentAlignment.MiddleLeft;
            aboutUsToolBar.ImageScaling = ToolStripItemImageScaling.None;
            aboutUsToolBar.Name = "aboutUsToolBar";
            aboutUsToolBar.Size = new Size(144, 64);
            aboutUsToolBar.Text = "About Us";
            aboutUsToolBar.Click += aboutUsToolStripMenuItem_Click;
            // 
            // exitSystemToolStripMenuItem
            // 
            exitSystemToolStripMenuItem.Image = (Image)resources.GetObject("exitSystemToolStripMenuItem.Image");
            exitSystemToolStripMenuItem.ImageAlign = ContentAlignment.MiddleLeft;
            exitSystemToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            exitSystemToolStripMenuItem.Name = "exitSystemToolStripMenuItem";
            exitSystemToolStripMenuItem.Size = new Size(158, 64);
            exitSystemToolStripMenuItem.Text = "Exit System";
            exitSystemToolStripMenuItem.Click += exitSystemToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(14, 64);
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // Student
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1069, 604);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(2, 2, 2, 2);
            Name = "Student";
            Text = "Student";
            WindowState = FormWindowState.Maximized;
            Load += Student_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem admissionToolStripMenuItem;
        private ToolStripMenuItem newAdmissionToolStripMenuItem;
        private ToolStripMenuItem upgradeSemesterToolStripMenuItem;
        private ToolStripMenuItem feesToolStripMenuItem;
        private ToolStripMenuItem studentDetailsToolStripMenuItem;
        private ToolStripMenuItem searchStudentToolStripMenuItem;
        private ToolStripMenuItem individualDetailsToolStripMenuItem;
        private ToolStripMenuItem teacherToolStripMenuItem;
        private ToolStripMenuItem addTeacherInformationToolStripMenuItem;
        private ToolStripMenuItem searchToolStripMenuItem;
        private ToolStripMenuItem removeStudentToolStripMenuItem;
        private ToolStripMenuItem aboutUsToolBar;
        private ToolStripMenuItem exitSystemToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ContextMenuStrip contextMenuStrip1;
    }
}