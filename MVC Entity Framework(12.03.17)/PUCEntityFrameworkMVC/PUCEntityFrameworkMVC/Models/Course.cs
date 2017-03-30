using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PUCEntityFrameworkMVC.Models
{
    public class Course
    {
        public int Id { get; set; }
        
        public string Code { get; set; }
        public string Name { get; set; }
        [Range(0.5, 5.0, ErrorMessage = "Credit range must be 0.5 ~ 5.0")]
        public decimal Credit { get; set; }
        public string Description { get; set; }

        public string DepartmentName { get; set; }

        public virtual List<Department> Departments  { get; set; }
        //add migration, seed, update, add controller

        public string SemesterName { get; set; }
        public virtual List<Semester> Semester { get; set; } 
    }
}