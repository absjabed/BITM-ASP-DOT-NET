using System;
using System.Data.SqlClient;
using UniversitySystemWebApp.BLL;
using UniversitySystemWebApp.Model;

namespace UniversitySystemWebApp.UI
{
    public partial class UpdateStudentUI : System.Web.UI.Page
    {
        StudentManager studentManager = new StudentManager();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void searchButton_Click(object sender, EventArgs e)
        {
            string regNo = registrationNumberTextBox.Text;

            Student aStudent = studentManager.GetByRegistrationNumber(regNo);

            if (aStudent == null)
            {
                messageLabel.Text = "No student found by the registration number";
                idHiddenField.Value = String.Empty;
                nameTextBox.Text = String.Empty;
                contactNumberTextBox.Text = String.Empty;
                emailTextBox.Text = String.Empty;
                departmentTextBox.Text = String.Empty;
            }
            else
            {
                messageLabel.Text = "Found the student";
                idHiddenField.Value = aStudent.Id.ToString();
                nameTextBox.Text = aStudent.Name;
                contactNumberTextBox.Text = aStudent.ContactNumber;
                emailTextBox.Text = aStudent.Email;
                //departmentTextBox.Text = aStudent.Department;
            }
        }

        protected void updateButton_Click(object sender, EventArgs e)
        {
            Student aStudent = new Student();
            aStudent.Id = Convert.ToInt32(idHiddenField.Value);
            aStudent.Email = emailTextBox.Text;
            aStudent.Name = nameTextBox.Text;
            aStudent.ContactNumber = contactNumberTextBox.Text;
            //aStudent.Department = departmentTextBox.Text;

            messageLabel.Text = studentManager.Update(aStudent);
        }
    }
}