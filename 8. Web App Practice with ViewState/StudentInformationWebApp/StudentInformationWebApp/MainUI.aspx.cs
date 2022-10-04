using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StudentInformationWebApp
{
    public partial class MainUI : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void saveButton_Click(object sender, EventArgs e)
        {
            List<StudentInfo> studentList;
            StudentInfo aStudentInfo = new StudentInfo();

            aStudentInfo.name = studentNameTextBox.Text;
            aStudentInfo.registrationId = registrationIDTextBox.Text;
            aStudentInfo.emailId = emailIDTextBox.Text;

            if (ViewState["Students"] == null)
            {
                studentList = new List<StudentInfo>();
            }
            else
            {
                studentList = (List<StudentInfo>)ViewState["Students"];
            }

            studentNameTextBox.Text = null;
            registrationIDTextBox.Text = null;
            emailIDTextBox.Text = null;

            studentList.Add(aStudentInfo);

            ViewState["Students"] = studentList;
        }

        protected void showAllButton_Click(object sender, EventArgs e)
        {
            List<StudentInfo> studentList = (List<StudentInfo>)ViewState["Students"];

            foreach (StudentInfo studentInfo in studentList)
            {
                studentInfoListBox.Items.Add(studentInfo.GetAllInformation());
            }
        }
    }
}