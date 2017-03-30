using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorAPP
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Sum :" + Add(firstNumber, secondNumber));
            Console.WriteLine("Subtract :" + Subtrat(firstNumber, secondNumber));
            Console.WriteLine("Multiply :" + Multiply(firstNumber, secondNumber));
            Console.WriteLine("Divide :" + Divide(firstNumber, secondNumber));
            Console.ReadKey();
        }

        static int Add(int firstNumber, int secondNumber)
        {
            int result = firstNumber + secondNumber;
            return result;
        }
        static int Subtrat(int firstNumber, int secondNumber)
        {
            int result = firstNumber - secondNumber;
            return result;
        }
        static int Multiply(int firstNumber, int secondNumber)
        {
            int result = firstNumber * secondNumber;
            return result;
        }
        static int Divide(int firstNumber, int secondNumber)
        {
            int result = firstNumber / secondNumber;
            return result;
        }
    }
}
