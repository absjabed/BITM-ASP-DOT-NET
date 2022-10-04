using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UniversityStudentsDataCRUDWebApp
{
    public partial class UpdateStudentsInfoUI : System.Web.UI.Page
    {
        string connectionString = @"Server = ABSJABED; Database=UniversityDB-Batch38; Integrated Security = True";
        protected void Page_Load(object sender, EventArgs e)
        {
            showStudentList();
        }
        protected void searchButton_Click(object sender, EventArgs e)
        {
            if (registrationNumberTextBox.Text == String.Empty)
            {
                messageLabel.ForeColor = System.Drawing.Color.Red;
                messageLabel.Text = "Please enter atleast one registration number!";
            }
            else
            {
                string regNo = registrationNumberTextBox.Text;
                Student aStudent = DoesRegistrationExists(regNo);

                if (aStudent == null)
                {
                    messageLabel.ForeColor = System.Drawing.Color.Red;
                    messageLabel.Text = "No student found!";
                }
                else
                {
                    idHiddenField.Value = aStudent.ID.ToString();
                    nameTextBox.Text = aStudent.Name;
                    contactNoTextBox.Text = aStudent.ContactNumber;
                    emailTextBox.Text = aStudent.Email;
                    departmentTextBox.Text = aStudent.Department;
                    messageLabel.ForeColor = System.Drawing.Color.Green;
                    messageLabel.Text = "Student record found!";
                }
            }
        }

        private Student DoesRegistrationExists(string regNo)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT * FROM Students WHERE RegistrationNo= '" + regNo + "'";

            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            Student aStudent = null;

            if (reader.HasRows)
            {
                reader.Read();
                aStudent = new Student();
                aStudent.ID = Convert.ToInt32(reader["Id"]);
                aStudent.Name = reader["Name"].ToString();
                aStudent.RegistrationNumber = reader["RegistrationNo"].ToString();
                aStudent.ContactNumber = reader["ContactNo"].ToString();
                aStudent.Email = reader["Email"].ToString();
                aStudent.Department = reader["Department"].ToString();
            }
            reader.Close();
            connection.Close();
            return aStudent;
        }

        protected void updateButton_Click(object sender, EventArgs e)
        {
            Student aStudent = new Student();
            aStudent.ID = Convert.ToInt32(idHiddenField.Value);
            aStudent.RegistrationNumber = registrationNumberTextBox.Text;
            aStudent.Name = nameTextBox.Text;
            aStudent.ContactNumber = contactNoTextBox.Text;
            aStudent.Email = emailTextBox.Text;
            aStudent.Department = departmentTextBox.Text;


            SqlConnection connection = new SqlConnection(connectionString);
            string query = "UPDATE Students SET Name='" + aStudent.Name + "', ContactNo='" + aStudent.ContactNumber + "', Email='" + aStudent.Email + "', Department='" + aStudent.Department + "' WHERE Id="+aStudent.ID;

            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            int rowEffected = command.ExecuteNonQuery();

            if (rowEffected > 0)
            {
                messageLabel.ForeColor = System.Drawing.Color.Green;
                messageLabel.Text = "Student info Updated!";
            }
            else
            {
                messageLabel.ForeColor = System.Drawing.Color.Red;
                messageLabel.Text = "faild to update!";
            }
            showStudentList();
        }

        private void showStudentList()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT * FROM Students";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            List<Student> students = new List<Student>();

            while (reader.Read())
            {
                Student aStudent = new Student();

                aStudent.ID = Convert.ToInt32(reader["Id"]);
                aStudent.Name = reader["Name"].ToString();
                aStudent.RegistrationNumber = reader["RegistrationNo"].ToString();
                aStudent.ContactNumber = reader["ContactNo"].ToString();
                aStudent.Email = reader["Email"].ToString();
                aStudent.Department = reader["Department"].ToString();

                students.Add(aStudent);
            }
            reader.Close();
            connection.Close();

            studentsGridView.DataSource = students;
            studentsGridView.DataBind();


        }

    }
}