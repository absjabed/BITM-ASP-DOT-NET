using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using UniversitySystemWebApp.Model;

namespace UniversitySystemWebApp.Gateway
{
    public class DepartmentGateway
    {
        private string connectionString =
            WebConfigurationManager.ConnectionStrings["UniversityDbConString"].ConnectionString;

        public List<Department> GetAllDepartments()
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            SqlCommand command = new SqlCommand();
            string query = "SELECT * FROM Departments";

            command.CommandText = query;
            command.Connection = connection;

            command.Connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            List<Department> departments = new List<Department>();
            while (reader.Read())
            {
                Department department = new Department();
                department.Id = Convert.ToInt32(reader["Id"]);
                department.Code = reader["Code"].ToString();
                department.Name = reader["Name"].ToString();

                departments.Add(department);
            }
            reader.Close();
            connection.Close();

            return departments;
        }
    }
}