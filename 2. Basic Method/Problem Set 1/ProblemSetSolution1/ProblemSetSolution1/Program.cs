using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSetSolution1
{
    class Program
    {
        static void Main(string[] args)
        {
            int upper, lower;

            Console.WriteLine("Enter a Upper limit: ");
            upper = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a lower limit: ");
            lower = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Number from lower to upper limit: ");
            for (int i = lower; i <= upper; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();

        }
    }
}
