using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    //Method are of mainly two types with parameter, parameterless
    //parameterised methods are of two types call by value, call by reference(changes the actual value of the variable permanantly)
    //To use the call by reference method 'ref' keyword can be used before the parameters where variables must be initialized.
    //{out <variable type> variable name } this pattern can be used for call by reference method where there is no need of initializing variables.
    class Program
    {
        static void Main(string[] args)
        {
            getName();
        }
        static void getName()
        {
            string name = string.Empty;
            name = Console.ReadLine();
            sayHi(name);
        }
        static void sayHi(string name)
        {
            Console.WriteLine($"Welcome back, {name}");
            Console.ReadLine();
        }
    }
}
