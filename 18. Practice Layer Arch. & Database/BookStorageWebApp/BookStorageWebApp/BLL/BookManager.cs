using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BookStorageWebApp.Getway;
using BookStorageWebApp.Model;

namespace BookStorageWebApp.BLL
{
    public class BookManager
    {
        BookGetway bookGetway = new BookGetway();
        public string AddBook(Book aBook)
        {
            bool tag = bookGetway.ISBN_exists(aBook.ISBN);

            if (tag)
            {
                return "ERROR! ISBN number Already exists.";
            }
            else
            {
                int rowEffected = bookGetway.AddBook(aBook);
                if (rowEffected > 0)
                {
                    return "Book Addition Succeed!";
                }
                else
                {
                    return "ERROR! Book Addition Failed.";
                }
                
            }
        }


        public List<Book> GetBooks()
        {
            return bookGetway.GetBooks();
        }

        public List<Book> SearchBook(string bookName)
        {
            return bookGetway.SearchBook(bookName);
        }
    }
}