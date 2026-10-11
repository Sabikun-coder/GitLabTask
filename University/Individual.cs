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
    public partial class Individual : Form
    {
        public Individual()
        {
            InitializeComponent();
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-APT72UCH;Initial Catalog=university;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select *from new_admission where NAID='" + txtReg.Text + "'";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);

            if (DS.Tables[0].Rows.Count != 0)
            {
                lblFullName.Text = DS.Tables[0].Rows[0][1].ToString();
                lblFather.Text = DS.Tables[0].Rows[0][2].ToString();
                lblGender.Text = DS.Tables[0].Rows[0][3].ToString();
                lblDOB.Text = DS.Tables[0].Rows[0][4].ToString();
                lblMobile.Text = DS.Tables[0].Rows[0][5].ToString();
                lblEmail.Text = DS.Tables[0].Rows[0][6].ToString();
                lblStandard.Text = DS.Tables[0].Rows[0][7].ToString();
                lblMedium.Text = DS.Tables[0].Rows[0][8].ToString();
                lblCollege.Text = DS.Tables[0].Rows[0][9].ToString();
                lblYear.Text = DS.Tables[0].Rows[0][10].ToString();
                lblAddress.Text = DS.Tables[0].Rows[0][11].ToString();
            }
            else
            {
                MessageBox.Show("No Data Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblFullName.Text = "___________";
                lblFather.Text = "___________";
                lblGender.Text = "___________";
                lblDOB.Text = "___________";
                lblMobile.Text = "___________";
                lblEmail.Text = "___________";
                lblStandard.Text = "___________";
                lblMedium.Text = "___________";
                lblCollege.Text = "___________";
                lblYear.Text = "___________";
                lblAddress.Text = "___________";
                txtReg.Clear();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lblFullName.Text = "___________";
            lblFather.Text = "___________";
            lblGender.Text = "___________";
            lblDOB.Text = "___________";
            lblMobile.Text = "___________";
            lblEmail.Text = "___________";
            lblStandard.Text = "___________";
            lblMedium.Text = "___________";
            lblCollege.Text = "___________";
            lblYear.Text = "___________";
            lblAddress.Text = "___________";
            txtReg.Clear();
        }
    }
}
