using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorldApp
{
    public partial class MainUI : Form
    {
        public MainUI()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello Wrold!");

        }

        private void HelloButton_Click(object sender, EventArgs e)
        {
            if (helloLabel.Text == "")
            {
                helloLabel.Text = "Hello World!";
            }
            else
            {
                helloLabel.Text = "";
            }

        }
    }
}
