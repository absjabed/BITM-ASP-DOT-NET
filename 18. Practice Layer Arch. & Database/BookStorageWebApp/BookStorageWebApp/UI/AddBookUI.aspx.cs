using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BookStorageWebApp.BLL;
using BookStorageWebApp.Model;

namespace BookStorageWebApp.UI
{
    public partial class AddBookUI : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void saveBookButton_Click(object sender, EventArgs e)
        {
            Book aBook = new Book();
            string bookName = bookNameTextBox.Text;
            string isbnNo = isbnNumberTextBox.Text;
            string author = authorNameTextBox.Text;

            if (isbnNumberTextBox.Text.Length != 13)
            {
                isbnNumberTextBox.Text = String.Empty;
                isbnNumberTextBox.Focus();
                messageLable.ForeColor = System.Drawing.Color.Red;
                messageLable.Text = "ISBN Number should be exect 13 charecter long";
            }
            else
            {

                aBook.Name = bookName;
                aBook.ISBN = isbnNo;
                aBook.Author = author;

                BookManager bookManager = new BookManager();
                string message = bookManager.AddBook(aBook);

                messageLable.ForeColor = System.Drawing.Color.Green;
                messageLable.Text = message;

                bookNameTextBox.Text = null;
                isbnNumberTextBox.Text = null;
                authorNameTextBox.Text = null;
            }


        }


        protected void authorNameTextBox_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}