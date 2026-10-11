using System.Data.SqlClient;
using MySqlX.XDevAPI;
using Org.BouncyCastle.Asn1.X509;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace University
{
    public partial class New_Admission : Form
    {
        public New_Admission()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            String fullName = txtFullName.Text;
            String fatherName = txtFatherName.Text;
            String gender = "";
            bool isChacked = radioButtonMale.Checked;
            if (isChacked)
            {
                gender = radioButtonMale.Text;
            }
            else
            {
                gender = radioButtonFemale.Text;
            }
            String dob = dateTimePickerDOB.Text;
            Int64 mobile = Int64.Parse(txtMobile.Text);
            String email = txtEmail.Text;
            String semester = txtSemester.Text;
            String program = txtProgram.Text;
            String college = txtCollege.Text;
            String session = txtSession.Text;
            String address = txtAddress.Text;

            SqlConnection con = new SqlConnection("Data Source=LAPTOP-APT72UCH;Initial Catalog=university;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into new_admission (fullname,fname,gender,dob,mobile,email,semester,prog,sname,session,address) values('" + fullName + "','" + fatherName + "','" + gender + "','" + dob + "','" + mobile + "','" + email + "','" + semester + "','" + program + "','" + college + "','" + session + "','" + address + "')";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            con.Close();
            MessageBox.Show("Data Saved", "Data", MessageBoxButtons.OK, MessageBoxIcon.Hand);

            this.Hide();
            New_Admission n = new New_Admission();
            n.Show();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtFullName.Clear();
            txtFatherName.Clear();
            txtAddress.Clear();
            txtFatherName.Clear();
            txtAddress.Clear();
            radioButtonMale.Checked = false;
            radioButtonMale.Checked = false;
            txtMobile.Clear();
            txtEmail.Clear();
            txtProgram.ResetText();
            txtSemester.ResetText();
            txtCollege.Clear();
            txtSession.ResetText();
        }

        private void New_Admission_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-APT72UCH;Initial Catalog=university;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select max(NAID) from new_admission";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            Int64 abc = Convert.ToInt64(DS.Tables[0].Rows[0][0]);
            label13.Text = (abc + 1).ToString();

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}
