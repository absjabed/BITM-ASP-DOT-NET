using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using BookBorrowSystemApp.Models;

namespace BookBorrowSystemApp.Gateway
{
    public class BookGateway:Gateway
    {
        public bool isExists(string title)
        {

            Query = "SELECT * FROM BooksTable WHERE Title = @title";
            Command = new SqlCommand(Query, Connection);
            Command.Parameters.Clear();
            Command.Parameters.AddWithValue("title", title);
            Connection.Open();
            SqlDataReader reader = Command.ExecuteReader();

            bool checkReaderRows = reader.HasRows;

            reader.Close();
            Connection.Close();
            return checkReaderRows;

        }

        public int SaveBook(Book book)
        {
            Query = "INSERT INTO BooksTable(Title,Author,Publisher,Status) VALUES(@title, @author, @publisher,@status)";
            Command = new SqlCommand(Query, Connection);
            Command.Parameters.Clear();
            Command.Parameters.AddWithValue("title", book.Title);
            Command.Parameters.AddWithValue("author", book.Author);
            Command.Parameters.AddWithValue("publisher", book.Publisher);
            Command.Parameters.AddWithValue("status", book.Status);
            Connection.Open();
            int rowAffected = Command.ExecuteNonQuery();
            Connection.Close();
            return rowAffected;
        }

        public bool isMemberExists(string memberNumber)
        {

            Query = "SELECT * FROM MembersTable WHERE MemberNumber = @number";
            Command = new SqlCommand(Query, Connection);
            Command.Parameters.Clear();
            Command.Parameters.AddWithValue("number", memberNumber);
            Connection.Open();
            SqlDataReader reader = Command.ExecuteReader();

            bool checkReaderRows = reader.HasRows;

            reader.Close();
            Connection.Close();
            return checkReaderRows;
        }

        public int SaveMember(Member member)
        {
            Query = "INSERT INTO MembersTable(MemberNumber,Name) VALUES(@number, @name)";
            Command = new SqlCommand(Query, Connection);
            Command.Parameters.Clear();
            Command.Parameters.AddWithValue("number", member.Number);
            Command.Parameters.AddWithValue("name", member.Name);
            Connection.Open();
            int rowAffected = Command.ExecuteNonQuery();
            Connection.Close();
            return rowAffected;
        }

        public IEnumerable<Book> GetAllBooks()
        {
            Query = "SELECT * FROM BooksTable";
            Command = new SqlCommand(Query, Connection);
            Connection.Open();
            Reader = Command.ExecuteReader();
            List<Book> books = new List<Book>();

            while (Reader.Read())
            {
                Book item = new Book()
                {
                    Id = Convert.ToInt32(Reader["Id"]),
                    Title = Reader["Title"].ToString(),
                    Author = Reader["Author"].ToString(),
                    Publisher = Reader["Publisher"].ToString(),
                    Status = Convert.ToBoolean(Reader["Status"].ToString())
                };
                books.Add(item);
            }
            Reader.Close();
            Connection.Close();
            return books;
        }

        public Book GetBooksById(int bookId)
        {
            Query = "SELECT * FROM BooksTable WHERE id = @Id";
            //Query = "SELECT Items.Id ItemId, Items.Name ItemName, Categories.Name CategoryName FROM Items,Categories WHERE Items.CategoryId = Categories.Id";
            Command = new SqlCommand(Query, Connection);
            Command.Parameters.Clear();
            Command.Parameters.AddWithValue("Id", bookId);
            Connection.Open();
            Reader = Command.ExecuteReader();
            Book itemr = new Book();
            while (Reader.Read())
            {
                Book item = new Book()
                {
                    Id = Convert.ToInt32(Reader["Id"]),
                    Title = Reader["Title"].ToString(),
                    Author = Reader["Author"].ToString(),
                    Publisher = Reader["Publisher"].ToString(),
                    Status = Convert.ToBoolean(Reader["Status"].ToString())
                };
                itemr = item;
            }
            Reader.Close();
            Connection.Close();
            return itemr;
        }
    }
}