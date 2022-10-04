using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentEntryDesktopApp
{
    public partial class MainUI : Form
    {

        Department department = new Department();
        private List<Student> students = new List<Student>();  
        public MainUI()
        {
            InitializeComponent();
        }

        private void departmentInfoSaveButton_Click(object sender, EventArgs e)
        {
            department.Code = departmentCodeTextBox.Text;
            department.Name = departmentNameTextBox.Text;
            departmentInfoSaveButton.Enabled = false;

        }

        private void studentInfoSaveButton_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student.Name = studentNameTextBox.Text;
            student.RegistrationNo = studentRegNoTextBox.Text;
            student.Email = studentEmailTextBox.Text;
            students.Add(student);

            studentNameTextBox.Text = null;
            studentRegNoTextBox.Text = null;
            studentEmailTextBox.Text = null;

            department.Students = students;

        }

        private void showDetailsButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(department.showDetails());
        }
    }
}
