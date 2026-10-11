using System;
using System.Data;
using System.Data.SqlClient;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
namespace UniversityManagementSystem
{
    public partial class TeacherForm : Form
    {
        SqlConnection con = new SqlConnection();
        public TeacherForm()
        {
            InitializeComponent();
            con.ConnectionString = @"Data Source=LAPTOP-APT72UCH;Initial Catalog=UniversityManagement;Integrated Security=True;TrustServerCertificate=True";

        }
        void ShowData()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from Teacher", con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;
        }
       


        private void btnSave_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Teacher (Name, Department, Course, Address) VALUES ('" + textName.Text + "', '" + textDept.Text + "', '" + textCourse.Text + "', '" + textAddress.Text + "')", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Saved Successfully!");
            con.Close();
        }
        private void btnRead_Click(object sender, EventArgs e)
        {
            con.Open();


            SqlDataAdapter da = new SqlDataAdapter("Select * from Teacher where TeacherID='" + textId.Text + "'", con);


            DataTable dt = new DataTable();
            da.Fill(dt);


            dataGridView1.DataSource = dt;

            con.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            con.Open();


            SqlCommand cmd = new SqlCommand("Update Teacher set Name='" + textName.Text + "', Department='" + textDept.Text + "', Course='" + textCourse.Text + "', Address='" + textAddress.Text + "' where TeacherID='" + textId.Text + "'", con);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Updated Successfully!");

            con.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete from Teacher where TeacherID='" + textId.Text + "'", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Deleted Successfully!");
            con.Close();

        }

        private void TeacherForm_Load_1(object sender, EventArgs e)
        {
            con.Open();
            ShowData();
            con.Close();
        }
    }
}
