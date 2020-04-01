using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Program p = new Program();
            Console.WriteLine("Enter a number:\n");
            double number1 = double.Parse(Console.ReadLine().ToString());
            Console.WriteLine("Enter the second number:\n");
            double number2 = double.Parse(Console.ReadLine().ToString());
            //Console.WriteLine("Your addition result is: " + p.Addition(number1, number2).ToString());
            Console.WriteLine("Your addition result is: " + Addition(number1, number2).ToString());
            Console.ReadLine();
        }

        static double Addition(double a, double b)
        {
            double c = a + b;
            return c;
        }
        // In case of void method no static keyword is needed
    }
}
