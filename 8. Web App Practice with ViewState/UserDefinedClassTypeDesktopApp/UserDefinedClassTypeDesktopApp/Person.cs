using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserDefinedClassTypeDesktopApp
{
    class Person
    {
        public string firstName,middleName,lastName ;

        public string GetFullName()
        {
            return firstName + " " + middleName + " " + lastName;
        }
    }
}
