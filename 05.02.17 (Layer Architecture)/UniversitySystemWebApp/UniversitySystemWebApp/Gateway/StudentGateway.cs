using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using UniversitySystemWebApp.BLL;
using UniversitySystemWebApp.Model;

namespace UniversitySystemWebApp.Gateway
{
    public class StudentGateway
    {
        private string connectionString =
            WebConfigurationManager.ConnectionStrings["UniversityDbConnString"].ConnectionString;


        public int SaveStudent(Student aStudent)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "INSERT INTO Students VALUES('" + aStudent.RegistrationNumber + "','" + aStudent.Name + "','" + aStudent.ContactNumber + "','" + aStudent.Email + "','" + aStudent.Department + "')";
            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            int rowEffected = command.ExecuteNonQuery();
            connection.Close();

            return rowEffected;
        }


        public bool DoesRegistrationNoExists(string regNo)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT * FROM Students WHERE RegistrationNo='" + regNo + "'";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            bool checkReaderRows = reader.HasRows;
            reader.Close();
            connection.Close();

            return checkReaderRows;
        }

        public List<Student> GetAllStudents()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT * FROM Students";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            List<Student> students = new List<Student>();

            while (reader.Read())
            {
                Student aStudent = new Student();

                aStudent.ID = Convert.ToInt32(reader["Id"]);
                aStudent.Name = reader["Name"].ToString();
                aStudent.RegistrationNumber = reader["RegistrationNo"].ToString();
                aStudent.ContactNumber = reader["ContactNo"].ToString();
                aStudent.Email = reader["Email"].ToString();
                aStudent.Department = reader["DepartmentId"].ToString();

                students.Add(aStudent);
            }
            reader.Close();
            connection.Close();

            return students;
        }


        public Student GetStudentByRegistrationNo(string regNo)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT * FROM Students WHERE RegistrationNo= '" + regNo + "'";

            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            Student aStudent = null;

            if (reader.HasRows)
            {
                reader.Read();
                aStudent = new Student();
                aStudent.ID = Convert.ToInt32(reader["Id"]);
                aStudent.Name = reader["Name"].ToString();
                aStudent.RegistrationNumber = reader["RegistrationNo"].ToString();
                aStudent.ContactNumber = reader["ContactNo"].ToString();
                aStudent.Email = reader["Email"].ToString();
                aStudent.Department = reader["DepartmentId"].ToString();
            }
            reader.Close();
            connection.Close();
            return aStudent;
        }

        public int UpdateStudentInfo(Student aStudent)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "UPDATE Students SET Name='" + aStudent.Name + "', ContactNo='" + aStudent.ContactNumber + "', " +
                           "Email='" + aStudent.Email + "', DepartmentId='" + aStudent.Department + "'WHERE Id=" + aStudent.ID;

            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            int rowEffected = command.ExecuteNonQuery();

            return rowEffected;
        }
    }
}