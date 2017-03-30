using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookInformationApp
{
    public partial class MainUI : Form
    {
        Hashtable bookHashtable = new Hashtable();
        
        public MainUI()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string bookISBN = ISBNaddTextBox.Text;
            string bookDetails = addBookDetailsTextBox.Text;

            bookHashtable.Add(bookISBN,bookDetails);

        }

        private void findButton_Click(object sender, EventArgs e)
        {
            string bookISBN = searchISBNTextBox.Text;
            string bookDetails = searchBookTextBox.Text;

            if (bookHashtable.Contains(bookISBN) | bookHashtable.Contains(bookDetails))
            {
                MessageBox.Show("Book found!","Search Book",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No such book found!", "Search Book", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            

        }
    }
}
