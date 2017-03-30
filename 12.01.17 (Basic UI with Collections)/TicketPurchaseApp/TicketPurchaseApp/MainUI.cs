using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketPurchaseApp
{
    public partial class MainUI : Form
    {
        string globalCustomerName;
        int globalNumberOfTickets, perTicketPrice = 10;

        public MainUI()
        {
            InitializeComponent();
        }

        private void totalPriceButton_Click(object sender, EventArgs e)
        {
            string customerName;
            int numberOfTickets;
           // Dictionary<string, int> myDictionary = new Dictionary<string, int>();
            
            customerName = customerNameTextBox.Text;
            numberOfTickets = Convert.ToInt32(numberOfTicketsTextBox.Text);
            
           // myDictionary.Add(customerName, numberOfTickets);

            globalCustomerName = customerName;
            globalNumberOfTickets = numberOfTickets;

            customerNameTextBox.Text = null;
            numberOfTicketsTextBox.Text = null;


            MessageBox.Show("Customer Name: " + customerName + 
                " Quantity: " + numberOfTickets + 
                " Total Price: " + numberOfTickets * perTicketPrice, 
                "Total Ticket Purchase", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void detailsButton_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Customer Name: " + globalCustomerName + "\n" + " Quantity: " + 
                globalNumberOfTickets + "\n" + " Total Price: " + globalNumberOfTickets * perTicketPrice, 
                "Details", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
