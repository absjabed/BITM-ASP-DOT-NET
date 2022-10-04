using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentEntryDesktopApp
{
    class Student
    {
        public string RegistrationNo { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public string showStudentInfo()
        {
            return "\n"+RegistrationNo + "     " + Name + "        " + Email;
        }

    }
}
