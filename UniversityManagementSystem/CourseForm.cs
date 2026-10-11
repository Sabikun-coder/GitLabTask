using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace UniversityManagementSystem
{
    public partial class CourseForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-APT72UCH;Initial Catalog=UniversityManagement;Integrated Security=True;");
        public CourseForm()
        {
            InitializeComponent();
        }
        void ShowData()
        {
            
            SqlDataAdapter da = new SqlDataAdapter("Select * from Course", con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            
            dataGridView1.DataSource = dt;
        }

        private void CourseForm_Load(object sender, EventArgs e)
        {
            con.Open();
            ShowData(); 
            con.Close();

        }
       
       
       

        private void btnInsert_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert into Course values( '" + txtCourseName.Text + "', '" + txtCredit.Text + "', '" + txtSemester.Text + "')", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Saved!");
            con.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            con.Open();


            SqlCommand cmd = new SqlCommand("Update Course set CourseName='" + txtCourseName.Text + "', Credit='" + txtCredit.Text + "', Semester='" + txtSemester.Text + "' where CourseID='" + txtCourseId.Text + "'", con);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Updated Successfully!");

            con.Close();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            con.Open();


            SqlDataAdapter da = new SqlDataAdapter("Select * from Course where CourseID='" + txtCourseId.Text + "'", con);


            DataTable dt = new DataTable();
            da.Fill(dt);


            dataGridView1.DataSource = dt;

            con.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            con.Open();

           
            SqlCommand cmd = new SqlCommand("Delete from Course where CourseID='" + txtCourseId.Text + "'", con);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Deleted Successfully!");

            con.Close();
        }
    }
    }


