using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UniversityStudentsDataCRUDWebApp
{
    public class Student
    {
        public int ID { get; set; }
        public string RegistrationNumber { get; set; }
        public string Name { get; set; }
        public string ContactNumber { get; set; }
        public string Email { get; set; }
        public string Department { get; set; }

    }
}