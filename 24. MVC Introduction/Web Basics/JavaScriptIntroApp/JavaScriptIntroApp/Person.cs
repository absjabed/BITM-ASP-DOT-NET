using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JavaScriptIntroApp
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public Person()
        {

        }
    }
}