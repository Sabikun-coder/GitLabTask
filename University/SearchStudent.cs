using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using University;

namespace University
{
    public partial class SearchStudent : Form
    {
        public SearchStudent()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void SearchStudent_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-APT72UCH;Initial Catalog=university;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select new_admission.NAID as Student_Id,new_admission.fullname as Full_Name,new_admission.fname as Father_Name,new_admission.gender as Gender,new_admission.dob as Date_of_Birth,new_admission.mobile as Number,new_admission.email as Email,new_admission.semester as Semester,new_admission.prog as Program,new_admission.sname as College,new_admission.session as Session,new_admission.address as Address,fees.fees as Fees from new_admission inner join fees on new_admission.NAID=fees.NAID";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            dataGridView1.DataSource = DS.Tables[0];
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-APT72UCH;Initial Catalog=university;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from new_admission where NAID='"+txtReg.Text+"'";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            dataGridView1.DataSource = DS.Tables[0];
        }
    }
}
