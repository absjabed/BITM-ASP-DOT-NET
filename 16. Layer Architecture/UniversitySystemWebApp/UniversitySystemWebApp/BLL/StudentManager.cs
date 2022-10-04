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
        public string SaveStudent(Student aStudent)
        {
            StudentGateway studentGateway = new StudentGateway();

            bool tag = studentGateway.DoesRegistrationNoExists(aStudent.RegistrationNumber);

            if (tag)
            {
                return "Sorry! Registration Number Already Exists.";
            }
            else
            {
                int rowEffected = studentGateway.SaveStudent(aStudent);

                if (rowEffected > 0)
                {
                    return "Saved Successfully!";
                }
                return "Student Save Failed!";
            }
        }

        public Student GetStudentByRegistrationNo(string RegNo)
        {
                StudentGateway studentGateway = new StudentGateway();

                Student student = studentGateway.GetStudentByRegistrationNo(RegNo);
           
            return student;

        }


        public string UpdateStudentInfo(Student aStudent)
        {
            StudentGateway studentGateway = new StudentGateway();
             int rowEffected = studentGateway.UpdateStudentInfo(aStudent);

             if (rowEffected > 0)
             {
                 return "Student info Updated!";
             }
                 return "faild to update!";
        }
    }
}