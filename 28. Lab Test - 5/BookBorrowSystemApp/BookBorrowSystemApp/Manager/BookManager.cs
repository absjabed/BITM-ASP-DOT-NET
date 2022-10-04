using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BookBorrowSystemApp.Gateway;
using BookBorrowSystemApp.Models;

namespace BookBorrowSystemApp.Manager
{
    public class BookManager
    {
        BookGateway bookGateway = new BookGateway();
        public AlertType SaveBook(Book book)
        {
            bool exists = bookGateway.isExists(book.Title);
            if (exists)
            {
                return new AlertType("This book already Exists!", "warning");
            }
            int row = bookGateway.SaveBook(book);
            if (row>0)
            {
                return new AlertType("This book has been saved!", "success");
            }
            return new AlertType("Failed save!", "danger");
        }

        public AlertType AddMember(Member member)
        {
            bool exists = bookGateway.isMemberExists(member.Number);
            if (exists)
            {
                return new AlertType("Member already Exists!", "warning");
            }
            int row = bookGateway.SaveMember(member);
            if (row > 0)
            {
                return new AlertType("This Member has been saved!", "success");
            }
            return new AlertType("Failed save!", "danger");
           
        }

        public IEnumerable<Book> GetAllBooks()
        {
            return bookGateway.GetAllBooks();
        }

        public Book GetBooksById(int bookId)
        {
            return bookGateway.GetBooksById(bookId);
        }

        public AlertType BorrowBook(BorrowBook borrowBook)
        {
            bool isExists = bookGateway.isMemberExists(borrowBook.Number);
            return new AlertType("xyz","info");
        }
    }
}