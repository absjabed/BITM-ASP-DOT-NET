using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradingSystemAPP
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Enter the number : ");
           double number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(check(number));
            Console.ReadKey();


        }

        static string check(double number)
        {
            if (number < 0 || number > 100)
            {
                return "Invalid";
            }
            else if (number <=100 && number >=80)
            {
                return "A+";
            }
            else if (number <= 79 && number >= 50)
            {
                return "A";
            }
            else
            {
                return "F";
            }
        }
    }
}
