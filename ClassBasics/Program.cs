using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine("Enter your name: ");
            var name = Console.ReadLine();
            name.ToLower();
            if (name is null) Console.WriteLine("Empty");
            Console.WriteLine(name.Length);
            int numerator = 10;
            int d = 2;
            if(numerator is 10)
            {
                Console.WriteLine(numerator / d);
                //Console.ReadLine();
            }
            bool IsNumberDivisible = (numerator % 5 is 0) ? true : false;
            Console.WriteLine(IsNumberDivisible);
            Console.ReadLine();

        }
        public Program()
        {
            Console.WriteLine("Program Started execution");
        }
    }
}
