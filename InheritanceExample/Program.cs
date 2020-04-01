using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.firstName = null;
            p.lastName = "Saha";
            p.print();
            Console.ReadLine();
        }
    }
    sealed class person
    {

    }

    public struct Person
    {
        public string firstName;
        public string lastName;
        public void print()
        {
            Console.WriteLine(firstName + " " + lastName);
        }
    }
}
