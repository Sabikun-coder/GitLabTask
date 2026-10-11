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
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
        }

        private void textStudentID_TextChanged(object sender, EventArgs e)
        {

        }

        private void textName_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-APT72UCH;Initial Catalog=UniversityManagement;Integrated Security=True;");

            string studentId = studentIDInputBox.Text;
            string Name = nameInputBox.Text;
            string department = cmbDepartment.SelectedItem.ToString();
            string semester = cmbSemester.SelectedItem.ToString();
            string phone = phoneInputBox.Text;
            string gender = cmbGender.SelectedItem.ToString();
            string email = textEmail.Text;

            string sql = "insert into Student (Name, Department, Semester, Phone, Gender,Email) values(" +
                          "'" + Name + "'," + "'" + department + "'," +
                          "'" + semester + "'," + "'" + phone + "'," +
                          "'" + gender + "'," +
                          "'" + email + "'" + ")";
            con.Open();
            SqlCommand command = new SqlCommand(sql, con);
            command.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Row inserted Successfully!! ");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-APT72UCH;Initial Catalog=UniversityManagement;Integrated Security=True;");

            string studentId = studentIDInputBox.Text;
            string Name = nameInputBox.Text;
            string department = cmbDepartment.SelectedItem.ToString();
            string semester = cmbSemester.SelectedItem.ToString();
            string phone = phoneInputBox.Text;
            string gender = cmbGender.SelectedItem.ToString();

            string sql = "update Student set Name = '" + Name +
                         "', Department = '" + department +
                         "', Semester = '" + semester +
                         "', Phone = '" + phone +
                         "', Gender = '" + gender +
                         "' where StudentId = '" + studentId + "'";

            con.Open();
            SqlCommand command = new SqlCommand(sql, con);
            command.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Row updated Successfully!! ");
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-APT72UCH;Initial Catalog=UniversityManagement;Integrated Security=True;");

            var query = "select * from Student";
            SqlCommand command = new SqlCommand(query, con);

            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataSet ds = new DataSet();

            adapter.SelectCommand = command;
            adapter.Fill(ds);
            con.Close();

            dgvStudent.DataSource = ds.Tables[0];
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-APT72UCH;Initial Catalog=UniversityManagement;Integrated Security=True;");

            string studentId = studentIDInputBox.Text;


            string sql = "delete from Student where StudentId = '" + studentId + "'";

            con.Open();
            SqlCommand command = new SqlCommand(sql, con);
            command.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Row deleted Successfully!! ");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
