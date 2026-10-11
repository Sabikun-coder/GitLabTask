using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace University
{
    public partial class Teacher : Form
    {
        public Teacher()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            String gender = "";
            bool isChacked = radioButtonMale.Checked;
            if (isChacked) {
                gender = radioButtonMale.Text;
            }
            else {
                gender = radioButtonFemale.Text;
            }
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-APT72UCH;Initial Catalog=university;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into teacher (fname,gender,dob,mobile,email,semester,prog,course,adrr) values('" + txtFullName.Text+"','"+ gender + "','"+ dateTimePickerDOB + "','"+ txtMobile.Text+ "','"+ txtEmail.Text + "','"+ txtSemester.Text + "','"+ txtProgram.Text + "','"+ txtCourse.Text + "','"+ txtAdderss.Text + "')";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);

            MessageBox.Show("Data Saved.","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
            txtAdderss.Clear();
            txtCourse.ResetText();
            txtEmail.Clear();
            txtSemester.ResetText();
            txtFullName.Clear();
            txtMobile.Clear();
            txtProgram.ResetText();
            radioButtonMale.Checked = false;
            radioButtonFemale.Checked = false;
            dateTimePickerDOB.ResetText();
        }
    }
}
