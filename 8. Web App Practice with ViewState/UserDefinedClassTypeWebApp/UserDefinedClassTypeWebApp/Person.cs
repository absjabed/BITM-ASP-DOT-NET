using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UserDefinedClassTypeWebApp
{
    [Serializable]
    class Person
    {
        public string firstName, middleName, lastName;

        public string GetFullName()
        {
            return firstName + " " + middleName + " " + lastName;
        }
    }
}