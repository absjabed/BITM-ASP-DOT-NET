using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSetSolution3
{
    class Program
    {
        static void Main(string[] args)
        {
            int count=0;
            for (int i = 1; i < 1000; i++)
            {
                if (i%3 == 0 | i%5 ==0)
                {
                    count += i;
                }
            }
            Console.WriteLine(count);
            Console.ReadKey();

        }
    }
}
