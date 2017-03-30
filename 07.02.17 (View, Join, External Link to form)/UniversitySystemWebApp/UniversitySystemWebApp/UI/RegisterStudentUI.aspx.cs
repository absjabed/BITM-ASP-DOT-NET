using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using UniversitySystemWebApp.BLL;
using UniversitySystemWebApp.Model;

namespace UniversitySystemWebApp.UI
{
    public partial class RegisterStudentUI : System.Web.UI.Page
    {

        StudentManager studentManager = new StudentManager();
        DepartmentManager departmentManager = new DepartmentManager();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ShowStudentsList();
                LoadDepartmentDropDownList();
            }
        }

        private void LoadDepartmentDropDownList()
        {
            List<Department> departments = departmentManager.GetAllDepartments();
            departmentDropDownList.DataTextField = "Name";
            departmentDropDownList.DataValueField = "Id";
            departmentDropDownList.DataSource = departments;
            departmentDropDownList.DataBind();
        }

        protected void registerButton_Click(object sender, EventArgs e)
        {
            Student aStudent = new Student();
            aStudent.Name = nameTextBox.Text;
            aStudent.RegistrationNumber = registrationNumberTextBox.Text;
            aStudent.ContactNumber = contactNumberTextBox.Text;
            aStudent.Email = emailTextBox.Text;
            aStudent.DepartmentId = Convert.ToInt32(departmentDropDownList.SelectedValue);
            
            messageLabel.Text = studentManager.Save(aStudent);
            ShowStudentsList();
        }

        private void ShowStudentsList()
        {
            List<StudentWithDepartment> students = studentManager.GetAllStudents();
            studentsGridView.DataSource = students;
            studentsGridView.DataBind();
        }
    }
}