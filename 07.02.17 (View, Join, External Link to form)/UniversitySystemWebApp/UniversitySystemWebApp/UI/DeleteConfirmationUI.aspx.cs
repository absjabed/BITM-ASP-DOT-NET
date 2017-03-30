using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UniversitySystemWebApp.BLL;
using UniversitySystemWebApp.Model;

namespace UniversitySystemWebApp.UI
{
    public partial class DeleteConfirmationUI : System.Web.UI.Page
    {
        StudentManager studentManager = new StudentManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Request.QueryString["id"]))
            {
                Response.Redirect("RegisterStudentUI.aspx");
            }
            else
            {
                int id = Convert.ToInt32(Request.QueryString["id"]);
                if (id == 0)
                {
                    Response.Redirect("RegisterStudentUI.aspx");
                }
                StudentWithDepartment student = studentManager.GetById(id);
                if (student == null)
                {
                    Response.Redirect("RegisterStudentUI.aspx");
                }
                else
                {
                    nameLabel.Text = student.StudentName;
                    regNoLabel.Text = student.RegNo;
                    emailLabel.Text = student.Email;
                    contactLabel.Text = student.Contact;
                    departmentLabel.Text = student.DeptName;
                    ViewState["Id"] = student.StudentId;
                }
            }
        }

        protected void cancelButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("RegisterStudentUI.aspx");
        }

        protected void deleteButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(ViewState["Id"]);
            studentManager.Delete(id);
            Response.Redirect("RegisterStudentUI.aspx");
        }
    }
}