using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentsYearlyCostApp
{
    public partial class MainUI : Form
    {
        public MainUI()
        {
            InitializeComponent();

            for (int i = 1; i <= 12; i++)
            {
                classListComboBox.Items.Add("Class " + i);
            }
        }

        public List<double> admissionFeeList = new List<double>()
        {
            10000,10000,10000,10000,10000,12000,12000,12000,15000,15000,15000,15000
        };
        public List<double> monthlyFeeList = new List<double>()
        {
            500,500,1000,1000,1000,1500,1500,1500,2000,2000,2700,2700
        };

        private void calculateTotalAmountButton_Click(object sender, EventArgs e)
        {

            if (classListComboBox.SelectedIndex == -1)
            {
                 MessageBox.Show("Please select a class form list!" ,"Students Yearly Cost Calculator",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                
            }
            else
            {
                double totalAmount = admissionFeeList[classListComboBox.SelectedIndex] +
                                         (monthlyFeeList[classListComboBox.SelectedIndex] * 12);
 
                if (getDiscountCheckBox.Checked)
                {
                    double totalAmountWithDiscount = totalAmount - (totalAmount*0.05);
                    MessageBox.Show("Total amount of one year with discount: " +totalAmountWithDiscount+".0","Students Yearly Cost Calculator",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Total amount of one year: " + totalAmount+".0","Students Yearly Cost Calculator",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    
                }
            }
            
        }
    }
}
