using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSalaryCalculationDesktopApp
{
    class EmployeeInformation
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public double Basic { get; set; }
        public double Medical { get; set; }
        public double Conveyance { get; set; }
        public int incrementCount { get; set; }
        public double TotalSalary { get; set; }

        public EmployeeInformation(string id, string name, string email, double basic, double percentageMedical, 
            double percentageConveyance)
        {
            Id = id;
            Name = name;
            Email = email;
            Basic = basic;
            Medical = basic * (percentageMedical / 100) + Medical;
            Conveyance = basic * (percentageConveyance / 100) + Conveyance;
        }

        public void CalculateIncrement(double percentage)
        {
            Basic = Basic*(percentage/100) + Basic;
            Medical = Medical * (percentage / 100) + Medical;
            Conveyance = Conveyance * (percentage / 100) + Conveyance;
        }

        public double GetTotalSalary()
        {
            return Basic + Medical + Conveyance;
        }
    }
}
