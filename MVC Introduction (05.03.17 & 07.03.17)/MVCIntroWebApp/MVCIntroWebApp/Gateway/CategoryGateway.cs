using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using MVCIntroWebApp.Models;

namespace MVCIntroWebApp.Gateway
{
    public class CategoryGateway:Gateway
    {
        public List<Category> GetAllCategories()
        {
            Query = "SELECT * FROM Categories";
            Command = new SqlCommand(Query,Connection);
            Connection.Open();
            Reader = Command.ExecuteReader();
            List<Category> categories = new List<Category>();
           
            while (Reader.Read())
            {
                Category category = new Category()
                {
                    Id = Convert.ToInt32(Reader["Id"]),
                    Name = Reader["Name"].ToString()
                };
                categories.Add(category);
            }
            Reader.Close();
            Connection.Close();
            return categories;
        }
    }
}