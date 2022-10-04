using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UniversitySystemWebApp
{
    public partial class IndexUI : System.Web.UI.Page
    {
        string connectionString = @"Server = .\SQLEXPRESS; Database=UniversityDB-Batch38; Integrated Security = True";
        protected void Page_Load(object sender, EventArgs e)
        {
            showStudentList();
        }

        protected void saveButton_Click(object sender, EventArgs e)
        {
            Student aStudent = new Student();
            aStudent.RegistrationNumber = registrationNumberTextBox.Text;
            aStudent.Name = nameTextBox.Text;
            aStudent.ContactNumber = contactNoTextBox.Text;
            aStudent.Email = emailTextBox.Text;
            aStudent.Department = departmentTextBox.Text;

            SqlConnection connection = new SqlConnection(connectionString);


            if (DoesRegistrationNoExists(aStudent.RegistrationNumber))
            {
                messageLabel.Text = "Registration Number Already Exists!";
            }
            else
            {
                string query = "INSERT INTO Students VALUES('" + aStudent.RegistrationNumber + "','" + aStudent.Name + "','" + aStudent.ContactNumber + "','" + aStudent.Email + "','" + aStudent.Department + "')";
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                int rowEffected = command.ExecuteNonQuery();
                connection.Close();

                if (rowEffected > 0)
                {
                    messageLabel.Text = "Saved Successfully!";
                }
                else
                {
                    messageLabel.Text = "Save Failed!";
                }
            }

            registrationNumberTextBox.Text = null;
            nameTextBox.Text = null;
            contactNoTextBox.Text = null;
            emailTextBox.Text = null;
            departmentTextBox.Text = null;
        }

        private bool DoesRegistrationNoExists(string regNo)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT * FROM Students WHERE RegistrationNo='"+regNo+"'";
            SqlCommand command = new SqlCommand(query,connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            bool checkReaderRows = reader.HasRows;
            reader.Close();
            connection.Close();

            return checkReaderRows;
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
