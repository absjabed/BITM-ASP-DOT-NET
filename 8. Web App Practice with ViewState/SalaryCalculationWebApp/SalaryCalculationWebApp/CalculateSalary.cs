using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SalaryCalculationWebApp
{
    [Serializable]
    public class CalculateSalary
    {
        public double basicSalary, medicalAllowance, conveyanceAllowance;
        double totalSalary;
        double medicalAllowancePercentage, conveyanceAllowancePercentage;

        public double GetTotalSalary()
        {
            medicalAllowancePercentage = basicSalary*(medicalAllowance/100);
            conveyanceAllowancePercentage = basicSalary*(conveyanceAllowance/100);

            totalSalary = basicSalary + medicalAllowancePercentage + 
                conveyanceAllowancePercentage;
            
            return totalSalary;
        }
    }
}