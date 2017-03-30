using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeSalaryCalculationDesktopApp
{
    public partial class MainUI : Form
    {
        private EmployeeInformation employee1;
        public MainUI()
        {
            InitializeComponent();
        }
        private void employeeSaveButton_Click(object sender, EventArgs e)
        {
           string  employeeId = employeeIdTextBox.Text;
           string  employeeName = employeeNameTextBox.Text;
           string employeeEmail = employeeEmailTextBox.Text;
           double employeeBasic = Convert.ToDouble(employeeBasicTextBox.Text);
           double employeeMedicalPercentage = Convert.ToDouble(employeeMedicalPercentageTextBox.Text);
           double employeeConvenyencePercentage = Convert.ToDouble(employeeConveyancePercentageTextBox.Text);

            foreach (Control c in employeeInfoGroupBox.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = null;
                    c.Enabled = false;
                }
            }
            employee1 = new EmployeeInformation(employeeId, employeeName, employeeEmail, employeeBasic, employeeMedicalPercentage, employeeConvenyencePercentage);

            increaseTextBox.Focus();
        }

        bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void increaseButton_Click(object sender, EventArgs e)
        {
            double increment = Convert.ToDouble(increaseTextBox.Text);
            employee1.CalculateIncrement(increment);
            employee1.incrementCount++;
            increaseTextBox.Text = null;
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            noOfIncrementTextBox.Text = employee1.incrementCount.ToString();
            showBasicTextBox.Text = employee1.Basic.ToString();
            showMedicalTextBox.Text = employee1.Medical.ToString();
            showConveyanceTextBox.Text = employee1.Conveyance.ToString();
            showTotalTextBox.Text = employee1.GetTotalSalary().ToString();
        }

        private void employeeBasicTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (!IsValidEmail(employeeEmailTextBox.Text))
            {
                MessageBox.Show("Invalid Email!");
                employeeEmailTextBox.Text = null;
            }
        }

        

    }
}
