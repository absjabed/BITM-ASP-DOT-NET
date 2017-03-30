using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSetSolution4
{
    class Program
    {
        static void Main(string[] args)
        {
            int sumOfSquars=0, sumofNumbers=0, difference;
            for (int i = 1; i <= 100; i++)
            {
                sumOfSquars += i*i;

                sumofNumbers += i;
            }

            difference = (sumofNumbers*sumofNumbers) - sumOfSquars;
            Console.WriteLine(difference);
            Console.ReadKey();
        }
    }
}
