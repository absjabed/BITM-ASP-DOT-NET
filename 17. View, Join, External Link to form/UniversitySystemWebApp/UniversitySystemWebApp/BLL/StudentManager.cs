using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UniversitySystemWebApp.Gateway;
using UniversitySystemWebApp.Model;

namespace UniversitySystemWebApp.BLL
{
    public class StudentManager
    {
        StudentGateway studentGateway = new StudentGateway();
        public string Save(Student aStudent)
        {
            bool doesExist = studentGateway.DoesRegistrationNoExist(aStudent.RegistrationNumber);
            if (doesExist)
            {
                return "Sorry! Registration number already exists.";
            }
            else
            {
                int rowAffected = studentGateway.Save(aStudent);
                if (rowAffected > 0)
                {
                    return "Student information saved successfully.";
                }
                return "Student information save failed.";
            }
        }

        public List<StudentWithDepartment> GetAllStudents()
        {
            return studentGateway.GetAllStudents();
        }

        public Student GetByRegistrationNumber(string regNo)
        {
            return studentGateway.GetByRegistrationNumber(regNo);
        }

        public string Update(Student aStudent)
        {
            int rowAffected = studentGateway.Update(aStudent);
            if (rowAffected > 0)
            {
                return "Student information updated successfully.";
            }
            return "Student information update failed.";
        }

        public StudentWithDepartment GetById(int id)
        {
            return studentGateway.GetById(id);
        }

        public void Delete(int id)
        {
            studentGateway.Delete(id);
        }
    }
}