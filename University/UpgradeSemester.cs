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
    public partial class UpgradeSemester : Form
    {
        public UpgradeSemester()
        {
            InitializeComponent();
        }

        private void txtUpgrade_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Semester Upgrade Warning!", "Confirm?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                SqlConnection con = new SqlConnection("Data Source=LAPTOP-APT72UCH;Initial Catalog=university;Integrated Security=True");
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "update new_admission set semester = '" + comboBoxTo.Text + "' where semester='" + comboBoxFrom.Text + "' and fullname='" + txtName.Text + "'";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);
                MessageBox.Show("Upgrade Successfull", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Upgrade Cancelled", "Cancle", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Clear();
                comboBoxFrom.ResetText();
                comboBoxTo.ResetText();
            }


        }

        private void UpgradeSemester_Load(object sender, EventArgs e)
        {

        }
    }
}
