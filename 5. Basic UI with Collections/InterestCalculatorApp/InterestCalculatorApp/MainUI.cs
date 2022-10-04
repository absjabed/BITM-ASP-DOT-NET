using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterestCalculatorApp
{
    public partial class MainUI : Form
    {
        public MainUI()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            string bankName = bankNameComboBox.Text;
            int year = Convert.ToInt32(timeInYearTextBox.Text);
            int balance = Convert.ToInt32(balanceTextBox.Text);
            double interest = 0.0;
            
            if(bankName=="BRAC")
            {
                interest = 0.06*balance*year;
                interestLabel.Text = interest.ToString();
            }
            else if(bankName=="DBBL")
            {
                interest = 0.07 * balance * year;
                interestLabel.Text = interest.ToString();
            }
            else if(bankName=="HSBC")
            {
                interest = 0.08 * balance * year;
                interestLabel.Text = interest.ToString();
            }
     else
           {
			MessageBox.Show("Bank name not found!");
            }

        }
    }
}
