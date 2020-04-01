using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
namespace TypeCastingAndConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = "123456.9";
            double number = double.Parse(num);
            Console.WriteLine(number);

            /*string var = "Hello345-3232wor705Ld";
            string mystr = Regex.Replace(var, @"\d", "");
            string mynumber = Regex.Replace(var, @"\D", "");
            Console.WriteLine(mystr);
            Console.WriteLine(mynumber);*/

            Console.ReadLine();
        }
    }
}
