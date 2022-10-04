using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UniversitySystemWebApp.Gateway;
using UniversitySystemWebApp.Model;

namespace UniversitySystemWebApp.BLL
{
    public class DepartmentManager
    {
        DepartmentGateway departmentGateway = new DepartmentGateway();

        public List<Department> GetAllDepartments()
        {
            return departmentGateway.GetAllDepartments();
        }
    }
}