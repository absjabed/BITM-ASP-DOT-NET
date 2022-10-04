using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSetSolution2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("All the Even numbers 1~100: ");
            for (int i = 1; i <= 100; i++)
            {
                if (i%2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
    }
}
