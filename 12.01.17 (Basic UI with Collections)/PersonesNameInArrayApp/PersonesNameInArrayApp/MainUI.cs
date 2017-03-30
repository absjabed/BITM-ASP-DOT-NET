using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonesNameInArrayApp
{

    public partial class MainUI : Form
    {
        public static string[] personNameArray = new string[5];
        int count = 0;
        public MainUI()
        {
            InitializeComponent();
        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            string personName;
            
            personName = nameTextBox.Text;

            if (count == 5)
            {
                MessageBox.Show("Array size out of bounds");
                nameTextBox.Text = null;
            }
            else
            {
                inputPersonName(personName, count);
                count++;   
            }
        }

        public void inputPersonName(string personName, int count)
        {
                personNameArray[count] = nameTextBox.Text;
                nameTextBox.Text = null;
        }
        private void showAllButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < personNameArray.Length; i++)
            {
                nameListBox.Items.Add(personNameArray[i].ToString());
                //Console.WriteLine(personNameArray[i]);
            }
            totalPersonTextBox.Text = personNameArray.Length.ToString();
        }
    }
}
