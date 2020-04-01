using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int mul = 2;
            int i = 0;
            Console.WriteLine("While loop");
            while (i<=10)
            {
                Console.WriteLine("2 x " + i + "= " + mul * i);
                i++;
            }
            Console.WriteLine("For loop");
            for (i=0; i<=10; i++)
            {
                Console.WriteLine("2 x " + i + "= " + mul * i);
            }
            Console.ReadLine();
        }
    }
}
