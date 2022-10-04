using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using UniversitySystemWebApp.Model;

namespace UniversitySystemWebApp.Gateway
{
    public class StudentGateway
    {
        private string connectionString =
            WebConfigurationManager.ConnectionStrings["UniversityDbConString"].ConnectionString;

        public int Save(Student aStudent)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "INSERT INTO Students VALUES('" + aStudent.RegistrationNumber + "', '" + aStudent.Name +
                           "', '" + aStudent.ContactNumber + "', '" + aStudent.Email + "', '" + aStudent.DepartmentId +
                           "')";

            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            int rowAffected = command.ExecuteNonQuery();
            connection.Close();

            return rowAffected;
        }

        public bool DoesRegistrationNoExist(string regNo)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT * FROM Students WHERE RegistrationNo='" + regNo + "'";
            SqlCommand command = new SqlCommand(query, connection);
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

        public List<StudentWithDepartment> GetAllStudents()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT * FROM StudentWithDepartment";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            List<StudentWithDepartment> students = new List<StudentWithDepartment>();

            while (reader.Read())
            {
                StudentWithDepartment aStudent = new StudentWithDepartment();
                aStudent.StudentId = Convert.ToInt32(reader["StudentId"]);
                aStudent.StudentName = reader["StudentName"].ToString();
                aStudent.RegNo = reader["RegistrationNo"].ToString();
                aStudent.Email = reader["Email"].ToString();
                aStudent.Contact = reader["ContactNo"].ToString();
                aStudent.DeptId = Convert.ToInt32(reader["DeptId"]);
                aStudent.DeptCode = reader["DeptCode"].ToString();
                aStudent.DeptName = reader["DeptName"].ToString();

                students.Add(aStudent);
            }
            reader.Close();
            connection.Close();

            return students;
        }

        public Student GetByRegistrationNumber(string regNo)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT * FROM Students WHERE RegistrationNo='" + regNo + "'";

            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            Student aStudent = null;
            if (reader.HasRows)
            {
                reader.Read();
                aStudent = new Student();
                aStudent.Id = Convert.ToInt32(reader["Id"]);
                aStudent.Name = reader["Name"].ToString();
                aStudent.RegistrationNumber = reader["RegistrationNo"].ToString();
                aStudent.ContactNumber = reader["ContactNo"].ToString();
                aStudent.Email = reader["Email"].ToString();
                if (reader["DepartmentId"] != DBNull.Value)
                {
                    aStudent.DepartmentId = Convert.ToInt32(reader["DepartmentId"]);
                }
            }
            reader.Close();
            connection.Close();
            return aStudent;
        }

        public int Update(Student aStudent)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            string query = "UPDATE Students SET Name='" + aStudent.Name + "', Email='" + aStudent.Email +
                           "', ContactNo='" + aStudent.ContactNumber + "', Department='" + aStudent.DepartmentId +
                           "' WHERE Id=" + aStudent.Id;

            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            int rowAffected = command.ExecuteNonQuery();
            connection.Close();

            return rowAffected;
        }

        public StudentWithDepartment GetById(int id)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT * FROM StudentWithDepartment WHERE StudentId=" + id;
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            StudentWithDepartment aStudent = null;
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                aStudent = new StudentWithDepartment();
                aStudent.StudentId = Convert.ToInt32(reader["StudentId"]);
                aStudent.StudentName = reader["StudentName"].ToString();
                aStudent.RegNo = reader["RegistrationNo"].ToString();
                aStudent.Email = reader["Email"].ToString();
                aStudent.Contact = reader["ContactNo"].ToString();
                aStudent.DeptId = Convert.ToInt32(reader["DeptId"]);
                aStudent.DeptCode = reader["DeptCode"].ToString();
                aStudent.DeptName = reader["DeptName"].ToString();
            }
            reader.Close();
            connection.Close();
            return aStudent;
        }

        public void Delete(int id)
        {
            string query = "DELETE FROM Students WHERE Id=" + id;
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}