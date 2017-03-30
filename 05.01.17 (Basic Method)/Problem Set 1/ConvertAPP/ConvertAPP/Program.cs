using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertAPP
{
    class Program
    {
        static void Main(string[] args)
        {
            //int i = 100;
            //bool b = true;
            //double d = 12.6;
            //long l = 12356;
            //l = i;
            //i = Convert.ToInt32(l);

            char c = 'C';
            int i = 19;
            c = Convert.ToChar(i);
            Console.WriteLine(c);
            Console.ReadKey();
        }
    }
}
