using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UniversityStudentsDataCRUDWebApp
{
    public partial class ViewAllStudentUI : System.Web.UI.Page
    {
        string connectionString = @"Server = ABSJABED; Database=UniversityDB-Batch38; Integrated Security = True";
        protected void Page_Load(object sender, EventArgs e)
        {
          int count = showStudentList();
            if (count == 0)
            {
                messageLabel.ForeColor = System.Drawing.Color.Red;
                messageLabel.Text = "Currently there is no data in the database";
            }
            else
            {
                messageLabel.ForeColor = System.Drawing.Color.Green;
                messageLabel.Text = "There are '"+count+"' students in the Database.";
            }
        }
        private int showStudentList()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT * FROM Students";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            int count = 0;
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

            count = students.Count;
            
            studentsGridView.DataSource = students;
            studentsGridView.DataBind();

            return count;
        }
    }
}