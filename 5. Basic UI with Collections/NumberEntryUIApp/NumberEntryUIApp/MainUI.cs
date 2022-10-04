using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberEntryUIApp
{
    public partial class MainUI : Form
    {
        List<double> numbers = new List<double>();
        public MainUI()
        {
            InitializeComponent();
        }

        private void addNumberButton_Click(object sender, EventArgs e)
        {
            double number = Convert.ToDouble(numberTextBox.Text);
            numbers.Add(number);
            numberTextBox.Text = null;


        }

        private void showAllNumberButton_Click(object sender, EventArgs e)
        {
            double total = 0;
            foreach (double aNumber in numbers)
            {
                numberListBox.Items.Add(aNumber);
                total += aNumber;
            }
            sumResultTextBox.Text = total.ToString();


        }
    }
}
