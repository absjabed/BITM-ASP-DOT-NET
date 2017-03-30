using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using BookStorageWebApp.Model;

namespace BookStorageWebApp.Getway
{
    public class BookGetway
    {
        private string connectionString =
           WebConfigurationManager.ConnectionStrings["UniversityDbConString"].ConnectionString;

        public int AddBook(Book aBook)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            //string query = "INSERT INTO BookEntryTable VALUES('" + aBook.ISBN + "', '" + aBook.Name +
            //               "', '" + aBook.Author + "')";
            string query = "INSERT INTO BookEntryTable VALUES(@isbn, @name, @author)";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.Clear();
            command.Parameters.AddWithValue("isbn", aBook.ISBN);
            command.Parameters.AddWithValue("name", aBook.Name);
            command.Parameters.AddWithValue("author", aBook.Author);

            connection.Open();
            int rowAffected = command.ExecuteNonQuery();
            connection.Close();
            return rowAffected;
        }

        public bool ISBN_exists(string isbn)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            //string query = "SELECT * FROM BookEntryTable WHERE ISBN ='" + isbn + "'";
            string query = "SELECT * FROM BookEntryTable WHERE ISBN = @isbn";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.Clear();
            command.Parameters.AddWithValue("isbn", isbn);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            bool checkReaderRows = reader.HasRows;
            //if (reader.HasRows)
            //{
            //    checkReaderRows = true;
            //}
            reader.Close();
            connection.Close();
            return checkReaderRows;
        }

        public List<Book> GetBooks()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT * FROM BookEntryTable";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            List<Book> books = new List<Book>();

            while (reader.Read())
            {
                Book aBook = new Book();
                aBook.ISBN = reader["ISBN"].ToString();
                aBook.Name = reader["Name"].ToString();
                aBook.Author = reader["Author"].ToString();

                books.Add(aBook);
            }
            reader.Close();
            connection.Close();

            return books;
        }

        public List<Book> SearchBook(string bookName)
        {
            SqlConnection connection = new SqlConnection(connectionString);
           // string query = "SELECT * FROM BookEntryTable WHERE Name LIKE '%"+bookName+"%'";
            string query = "SELECT * FROM BookEntryTable WHERE Name LIKE @bookName";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.Clear();
            command.Parameters.Add("bookName", SqlDbType.VarChar);
            command.Parameters["bookName"].Value = "%" + bookName + "%";
           // command.Parameters.AddWithValue("bookName", bookName);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            List<Book> books = new List<Book>();

            while (reader.Read())
            {
                Book aBook = new Book();
                aBook.ISBN = reader["ISBN"].ToString();
                aBook.Name = reader["Name"].ToString();
                aBook.Author = reader["Author"].ToString();

                books.Add(aBook);
            }
            reader.Close();
            connection.Close();

            return books;
        }
    }
}
