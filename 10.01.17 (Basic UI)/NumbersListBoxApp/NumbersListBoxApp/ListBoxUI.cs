using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumbersListBoxApp
{
    public partial class ListBoxUI : Form
    {
        public ListBoxUI()
        {
            InitializeComponent();
        }

        private void numbersButton_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(numberTextBox.Text);

            numbersListBox.Items.Clear();
            for (int i = 1; i <= number; i++)
            {
                numbersListBox.Items.Add(i);
            }
        }
    }
}
