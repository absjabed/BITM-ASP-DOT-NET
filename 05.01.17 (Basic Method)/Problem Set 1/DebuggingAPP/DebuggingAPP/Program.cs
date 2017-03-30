using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebuggingAPP
{
    class Program
    {
        static void Main(string[] args)
        {
            Print();
            double result = Add(10, 25);
            Console.WriteLine("Sum: "+ result);
            Console.ReadKey();
        }

        static void Print()
        {
            Console.WriteLine("hello world!");
        }

        static double Add(double firstNumber, double secondNumber)
        {
            double result = firstNumber + secondNumber;
            return result;
        }
    }
}
