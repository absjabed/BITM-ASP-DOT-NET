using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using MVCIntroWebApp.Models;

namespace MVCIntroWebApp.Gateway
{
    public class ItemGateway:Gateway
    {
        public List<ItemWithCategory> GetAllItems()
        {
            Query = "SELECT * FROM ItemWithCategory";
            //Query = "SELECT Items.Id ItemId, Items.Name ItemName, Categories.Name CategoryName FROM Items,Categories WHERE Items.CategoryId = Categories.Id";
            Command = new SqlCommand(Query, Connection);
            Connection.Open();
            Reader = Command.ExecuteReader();
            List<ItemWithCategory> Items = new List<ItemWithCategory>();

            while (Reader.Read())
            {
                ItemWithCategory item = new ItemWithCategory()
                {
                    ItemId = Convert.ToInt32(Reader["ItemId"]),
                    ItemName = Reader["ItemName"].ToString(),
                    ItemPrice = Convert.ToDecimal(Reader["ItemPrice"]),
                    CategoryId = Convert.ToInt32(Reader["CategoryId"]),
                    CategoryName = Reader["CategoryName"].ToString()
                };
                Items.Add(item);
            }
            Reader.Close();
            Connection.Close();
            return Items;
        }

        public int Save(Item item)
        {
            Query = "INSERT INTO Items VALUES(@name, @price, @categoryId)";
            Command = new SqlCommand(Query, Connection);
            Command.Parameters.Clear();
            Command.Parameters.AddWithValue("name", item.Name);
            Command.Parameters.AddWithValue("price", item.Price);
            Command.Parameters.AddWithValue("categoryId", item.CategoryId);

            Connection.Open();
            int rowAffected = Command.ExecuteNonQuery();
            Connection.Close();
            return rowAffected;
        }

        public bool ItemExists(string name)
        {
            Query = "SELECT * FROM Items WHERE Name = @namew";
            Command = new SqlCommand(Query, Connection);
            Command.Parameters.Clear();
            Command.Parameters.AddWithValue("namew", name);
            Connection.Open();
            Reader = Command.ExecuteReader();

            bool checkReaderRows = Reader.HasRows;
            Reader.Close();
            Connection.Close();
            return checkReaderRows;
        }


        public List<ItemWithCategory> GetItemsByCategory(int id)
        {
            Query = "SELECT * FROM ItemWithCategory WHERE CategoryId = @categoryId";
            //Query = "SELECT Items.Id ItemId, Items.Name ItemName, Categories.Name CategoryName FROM Items,Categories WHERE Items.CategoryId = Categories.Id";
            Command = new SqlCommand(Query, Connection);
            Command.Parameters.Clear();
            Command.Parameters.AddWithValue("categoryId", id);
            Connection.Open();
            Reader = Command.ExecuteReader();
            List<ItemWithCategory> Items = new List<ItemWithCategory>();

            while (Reader.Read())
            {
                ItemWithCategory item = new ItemWithCategory()
                {
                    ItemId = Convert.ToInt32(Reader["ItemId"]),
                    ItemName = Reader["ItemName"].ToString(),
                    ItemPrice = Convert.ToDecimal(Reader["ItemPrice"]),
                    CategoryId = Convert.ToInt32(Reader["CategoryId"]),
                    CategoryName = Reader["CategoryName"].ToString()
                };
                Items.Add(item);
            }
            Reader.Close();
            Connection.Close();
            return Items;
        }
    }
}