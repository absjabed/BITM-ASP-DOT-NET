using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UniversitySystemWebApp.BLL;
using UniversitySystemWebApp.Gateway;
using UniversitySystemWebApp.Model;

namespace UniversitySystemWebApp
{
    public partial class UpdateStudentUI : System.Web.UI.Page
    {
        string connectionString = @"Server = .\SQLEXPRESS; Database=UniversityDB-Batch38; Integrated Security = True";
        protected void Page_Load(object sender, EventArgs e)
        {
            showStudentList();
        }

        protected void searchButton_Click(object sender, EventArgs e)
        {
            string regNo = registrationNumberTextBox.Text;
            
           StudentManager studentManager = new StudentManager();

            Student aStudent = studentManager.GetStudentByRegistrationNo(regNo);

            if (aStudent == null)
            {
                messageLabel.ForeColor = System.Drawing.Color.Red;
                messageLabel.Text = "No Student found!";
            }
            else
            {
                messageLabel.ForeColor = System.Drawing.Color.Green;
                messageLabel.Text = "Student Found!";
                idHiddenField.Value = aStudent.ID.ToString();
                nameTextBox.Text = aStudent.Name;
                contactNoTextBox.Text = aStudent.ContactNumber;
                emailTextBox.Text = aStudent.Email;
                departmentTextBox.Text = aStudent.Department;
            }
           
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

            StudentManager studentManager = new StudentManager();
            messageLabel.Text = studentManager.UpdateStudentInfo(aStudent);
            showStudentList();
        }

      private void showStudentList()
        {
            StudentGateway studentGateway = new StudentGateway();
            List<Student> students = studentGateway.GetAllStudents();

            studentsGridView.DataSource = students;
            studentsGridView.DataBind();
        }
    }
}