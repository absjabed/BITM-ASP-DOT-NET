using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using MobileStoreWebApp.Model;

namespace MobileStoreWebApp.Getway
{
    public class MobileGatway
    {
        private string connectionString =
          WebConfigurationManager.ConnectionStrings["UniversityDbConString"].ConnectionString;
       
        public bool IsExists(string imei)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT * FROM t_Handsets WHERE IMEI = @imeinum";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.Clear();
            command.Parameters.AddWithValue("imeinum", imei);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            bool checkReaderRows = reader.HasRows;

            reader.Close();
            connection.Close();
            return checkReaderRows;
        }

        public int SaveMobile(MobilePhone aMobilePhone)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            string query = "INSERT INTO t_Handsets VALUES(@model, @imei, @price)";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.Clear();
            command.Parameters.AddWithValue("model", aMobilePhone.ModelName);
            command.Parameters.AddWithValue("imei", aMobilePhone.IMEI);
            command.Parameters.AddWithValue("price", aMobilePhone.Price);

            connection.Open();
            int rowAffected = command.ExecuteNonQuery();
            connection.Close();
            return rowAffected;
        }

        public List<MobilePhone> SearchMobilePrice(decimal startingPrice, decimal endingPrice)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT * FROM t_Handsets WHERE Price BETWEEN @start AND @end";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.Clear();
            command.Parameters.AddWithValue("start", startingPrice);
            command.Parameters.AddWithValue("end", endingPrice);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            List<MobilePhone> phones = new List<MobilePhone>();

            while (reader.Read())
            {
                MobilePhone mobile = new MobilePhone();
                mobile.Id = Convert.ToInt32(reader["Id"].ToString());
                mobile.ModelName = reader["ModelName"].ToString();
                mobile.IMEI = reader["IMEI"].ToString();
                mobile.Price = Convert.ToDecimal(reader["Price"].ToString());
                phones.Add(mobile);
            }
            reader.Close();
            connection.Close();
            return phones;
        }

        public List<MobilePhone> GetMobiles()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT * FROM t_Handsets";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            List<MobilePhone> phones = new List<MobilePhone>();

            while (reader.Read())
            {
                MobilePhone mobile = new MobilePhone();
                mobile.Id = Convert.ToInt32(reader["Id"].ToString());
                mobile.ModelName = reader["ModelName"].ToString();
                mobile.IMEI = reader["IMEI"].ToString();
                mobile.Price = Convert.ToDecimal(reader["Price"].ToString());
                phones.Add(mobile);
            }
            reader.Close();
            connection.Close();

            return phones;    
        }

        public MobilePhone getByImei(string imei)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT * FROM t_Handsets WHERE IMEI=@imeinum";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.Clear();
            command.Parameters.AddWithValue("imeinum", imei);
            connection.Open();

            SqlDataReader reader = command.ExecuteReader();
            MobilePhone mobile = new MobilePhone();
            
            while (reader.Read())
            {
                mobile.Id = Convert.ToInt32(reader["Id"].ToString());
                mobile.ModelName = reader["ModelName"].ToString();
                mobile.IMEI = reader["IMEI"].ToString();
                mobile.Price = Convert.ToDecimal(reader["Price"].ToString());
            }
            reader.Close();
            connection.Close();

            return mobile;    

        }
    }
}