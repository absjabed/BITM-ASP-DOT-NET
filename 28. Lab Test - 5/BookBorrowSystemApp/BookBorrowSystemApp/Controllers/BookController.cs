using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BookBorrowSystemApp.Manager;
using BookBorrowSystemApp.Models;

namespace BookBorrowSystemApp.Controllers
{
    public class BookController : Controller
    {
        BookManager bookManager = new BookManager();
        //
        // GET: /Book/
        public ActionResult Index()
        {
            return View();
        }

        //Save Book

        [HttpGet]
        public ActionResult SaveBook()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SaveBook(Book book)
        {

           AlertType alert = bookManager.SaveBook(book);
            ViewBag.alert = alert;
            return View();
        }

        //Add Member

        [HttpGet]
        public ActionResult AddMember()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddMember(Member member)
        {
            AlertType alert = bookManager.AddMember(member);
            ViewBag.alert = alert;
            return View();
        }


        //Borrow Book

        [HttpGet]
        public ActionResult BorrowBook()
        {
            IEnumerable<Book> books = bookManager.GetAllBooks();
            ViewBag.Books = books;
            return View();
        }
        [HttpPost]
        public ActionResult BorrowBook(BorrowBook borrowBook)
        {
            AlertType alert = bookManager.BorrowBook(borrowBook);
            ViewBag.alert = alert;
            return View();
        }

        public JsonResult GetBooksById(int bookId)
        {
            Book book = bookManager.GetBooksById(bookId);
            return Json(book, JsonRequestBehavior.AllowGet);
        }
        //return Book

        [HttpGet]
        public ActionResult ReturnBook()
        {
            return View();
        }
        [HttpPost]
        public ActionResult ReturnBook(object obj)
        {
            return View();
        }


	}
}