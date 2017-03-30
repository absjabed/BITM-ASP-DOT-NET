using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using SalesMVCApp.Models;

namespace SalesMVCApp.Gateway
{
    public class ItemGateway:Gateway
    {
        public List<Items> GetAllItems()
        {

            Query = "SELECT * FROM ItemsTable";
            //Query = "SELECT Items.Id ItemId, Items.Name ItemName, Categories.Name CategoryName FROM Items,Categories WHERE Items.CategoryId = Categories.Id";
            Command = new SqlCommand(Query, Connection);
            Connection.Open();
            Reader = Command.ExecuteReader();
            List<Items> Itemss = new List<Items>();

            while (Reader.Read())
            {
                Items item = new Items()
                {
                    Id = Convert.ToInt32(Reader["Id"]),
                    Name = Reader["ItemName"].ToString(),
                    
                };
                Itemss.Add(item);
            }
            Reader.Close();
            Connection.Close();
            return Itemss;
        }

        public int Save(ItemSold item)
        {
            Query = "INSERT INTO SalesTable(CustomerName,ItemId,Quantity) VALUES(@name, @itemId, @quantity)";
            Command = new SqlCommand(Query, Connection);
            Command.Parameters.Clear();
            Command.Parameters.AddWithValue("name", item.CustomerName);
            Command.Parameters.AddWithValue("itemId", item.ItemId);
            Command.Parameters.AddWithValue("quantity", item.Quantity);
            Connection.Open();
            int rowAffected = Command.ExecuteNonQuery();
            Connection.Close();
            return rowAffected;
        }

        public List<ItemSold> ViewById(int itemId)
        {
            Query = "SELECT * FROM SalesTable WHERE ItemId = @categoryId";
            //Query = "SELECT Items.Id ItemId, Items.Name ItemName, Categories.Name CategoryName FROM Items,Categories WHERE Items.CategoryId = Categories.Id";
            Command = new SqlCommand(Query, Connection);
            Command.Parameters.Clear();
            Command.Parameters.AddWithValue("categoryId", itemId);
            Connection.Open();
            Reader = Command.ExecuteReader();
            List<ItemSold> itemssList = new List<ItemSold>();

            while (Reader.Read())
            {
                ItemSold item = new ItemSold()
                {
                    Id = Convert.ToInt32(Reader["Id"]),
                    CustomerName = Reader["CustomerName"].ToString(),
                    ItemId = Convert.ToInt32(Reader["ItemId"]),
                    Quantity = Convert.ToInt32(Reader["Quantity"])
                };

                itemssList.Add(item);
            }
            Reader.Close();
            Connection.Close();
            return itemssList;
        }
    }
}