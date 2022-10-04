using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentEntryDesktopApp
{
    class Department
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public List<Student> Students { get; set; }

        public Department()
        {
            Students = new List<Student>();
        }

        public string showDetails()
        {
            string details = "Department ID: " + Code + "Name: " + Name+"\n"+"Student Reg No        Name        Email";

            foreach (Student student in Students)
            {
                details += student.showStudentInfo()+"\n";
            }
            return details;
        }
    }
}
