using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Program3 p = new Program3(2, 3, 5);
            Console.ReadLine();
        }
    }

    class Program2
    {
        protected int a, b;
        public Program2()
        {
            Console.WriteLine("Constructor called");
        }
        public Program2(int a, int b)
        {
            this.a = a;
            this.b = b;
            Console.WriteLine("Base constructor called");
            Console.WriteLine(a + b);
        }
    }
    class Program3 : Program2{
        protected int c;
        public Program3(int a, int b, int c):base( a, b)
        {
            this.c = c;
            Console.WriteLine("Child Constructor called");
            Console.WriteLine(c);
        }
        public Program3()
        {
            Console.WriteLine("No parameter passed.");
        }
    }
}
