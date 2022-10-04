using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SalaryCalculationWebApp
{
    public partial class MainUI : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void calculateSalaryButton_Click(object sender, EventArgs e)
        {
            CalculateSalary calculateSalary;
         
            double basicSalary = Convert.ToDouble(basicSalaryTextBox.Text);
            double medicalAllowance = Convert.ToDouble(medicalAllowanceTextBox.Text);
            double conveyanceAllowance = Convert.ToDouble(conveyanceAllowanceTextBox.Text);

            if (ViewState["Salary"] == null)
            {
                calculateSalary = new CalculateSalary();
            }
            else
            {
                calculateSalary = (CalculateSalary) ViewState["Salary"];
            }

            calculateSalary.basicSalary = basicSalary;
            calculateSalary.medicalAllowance = medicalAllowance;
            calculateSalary.conveyanceAllowance = conveyanceAllowance;

            ViewState["Salary"] = calculateSalary;

            basicSalaryTextBox.Text = null;
            medicalAllowanceTextBox.Text = null;
            conveyanceAllowanceTextBox.Text = null;

        }

        protected void showTotalButton_Click(object sender, EventArgs e)
        {
            CalculateSalary calculateSalary = (CalculateSalary) ViewState["Salary"];
            double totalSalary;

            totalSalary = calculateSalary.GetTotalSalary();
            totalLabel.Text = totalSalary.ToString("F");
        }
    }
}