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

namespace Book_Information_Keeper
{
    public partial class Book_Information_Keeper : Form
    {
        Hashtable booktable = new Hashtable();
        public Book_Information_Keeper()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string isbn = isbnTextBox.Text;
            string name = nameTextBox.Text;
            booktable.Add(isbn,name);
            addListBox.Items.Add(isbn);
            addListBox.Items.Add(name);
            Clear();
            
        }

        private void Clear()
        {
            isbnTextBox.Clear();
            nameTextBox.Clear();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {

            if (isbnRadioButton.Checked)
            {
                string findisbn = isbnnameTextBox.Text;
                searchTestBox.Text = booktable[findisbn].ToString();
            }
            if (nameRadioButton.Checked)
           
            {
                string findname = isbnnameTextBox.Text;
                searchTestBox.Text = booktable[findname].ToString();
            }

         }

    }

 }

