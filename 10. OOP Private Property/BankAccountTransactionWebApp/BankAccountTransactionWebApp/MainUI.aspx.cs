using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BankAccountTransactionWebApp
{
    public partial class MainUI : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void createAccountButton_Click(object sender, EventArgs e)
        {
            BankAccount account1 =new BankAccount();
            account1.AccountNumber = accountNumberTextBox.Text;
            account1.CustomerName = customerNameTextBox.Text;
            account1.AccountBalance = 0.0;
            ViewState["account1info"] = account1;
            accountNumberTextBox.Text = null;
            customerNameTextBox.Text = null;
            confirmationLabel.Text = "Account Created!";
        }

        protected string depositeButton_Click(object sender, EventArgs e)
        {
            BankAccount account1 = new BankAccount() ;
            account1 = (BankAccount) ViewState["account1info"];
            double amount = Convert.ToDouble(amountTextBox.Text);
            
            account1.DepositeAmount(amount);
            
        }

        protected string withdrawButton_Click(object sender, EventArgs e)
        {
            BankAccount account1 = (BankAccount)ViewState["account1info"];
            double amount = Convert.ToDouble(amountTextBox.Text);
            
        }

        protected string reportButton_Click(object sender, EventArgs e)
        {
            return 
        }
    }
}