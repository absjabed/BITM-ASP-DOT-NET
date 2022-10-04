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
    public partial class IndexUI : System.Web.UI.Page
    {
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

            StudentManager studentManager = new StudentManager();
            messageLabel.Text = studentManager.SaveStudent(aStudent);
         
            registrationNumberTextBox.Text = null;
            nameTextBox.Text = null;
            contactNoTextBox.Text = null;
            emailTextBox.Text = null;
            departmentTextBox.Text = null;
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
