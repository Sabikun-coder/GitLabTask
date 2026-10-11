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
    public partial class txtFees : Form
    {
        public txtFees()
        {
            InitializeComponent();
        }

        private void txtReg_TextChanged(object sender, EventArgs e)
        {
            if (txtReg.Text != "")
            {
                //from db to boxes
                SqlConnection con = new SqlConnection("Data Source=LAPTOP-APT72UCH;Initial Catalog=university;Integrated Security=True");
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select fullname,fname,session from new_admission where NAID='" + txtReg.Text + "'";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);
                if (DS.Tables[0].Rows.Count != 0)
                {
                    txtFullName.Text = DS.Tables[0].Rows[0][0].ToString();
                    txtFather.Text = DS.Tables[0].Rows[0][1].ToString();
                    txtSesson.Text = DS.Tables[0].Rows[0][2].ToString();
                }
                else
                {
                    txtFullName.Text = "_____";
                    txtFather.Text = "_____";
                    txtSesson.Text = "_____";

                }
            }
            else
            {
                txtFullName.Text = "_____";
                txtFather.Text = "_____";
                txtSesson.Text = "_____";

            }
        }

        private void txtFees_Load(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            //fees entru
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-APT72UCH;Initial Catalog=university;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "insert into fees (NAID,fees) values('" + txtReg.Text + "','" + txtFee.Text + "')";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);
                if (MessageBox.Show("Fees Submission Successfull.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk) == DialogResult.OK)
                {
                    //clear fealds
                    txtReg.Text = "";
                    txtFee.Text = "";
                    txtFullName.Text = "_____";
                    txtFather.Text = "_____";
                    txtSesson.Text = "_____";
                }
        


        }
    }
}
