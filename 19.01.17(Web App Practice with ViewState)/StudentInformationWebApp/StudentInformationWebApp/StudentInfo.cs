using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentInformationWebApp
{
    [Serializable]
    public class StudentInfo
    {
        public string name, registrationId, emailId;

        public string GetAllInformation()
        {
            return "Student Name: " + name + "\n" + "Registration ID: " + registrationId + "\n" + "Email ID: " + emailId;
        }

    }
}