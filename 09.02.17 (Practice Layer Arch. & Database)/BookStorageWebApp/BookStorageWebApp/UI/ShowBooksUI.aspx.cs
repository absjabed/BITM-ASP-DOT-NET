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
    public partial class ShowBooksUI : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ShowBooksList();
            }
        }

        private void ShowBooksList()
        {
            BookManager bookManager = new BookManager();

            List<Book> books = new List<Book>();
            books = bookManager.GetBooks();
            booksGridView.DataSource = books;
            booksGridView.DataBind();
        }

        protected void searchButton_Click(object sender, EventArgs e)
        {
            BookManager bookManager = new BookManager();

            string bookName = searchBookNameTextBox.Text;


            List<Book> books = new List<Book>();
            books = bookManager.SearchBook(bookName);
            booksGridView.DataSource = books;
            booksGridView.DataBind();

        }
    }
}