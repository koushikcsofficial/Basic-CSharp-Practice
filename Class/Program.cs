using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.Email = "aoc@auc.com";
            Console.ReadLine();
        }
    }
    class Person
    {
        string email;
        public Person()
        {
            email = string.Empty;
        }
        //string password;
        public string Email {
            get => email;
            set { email = (!string.IsNullOrEmpty(value))?hash(value):throw new ArgumentException("Email address not found"); } 
        }

        private string hash(string value)
        {
            try
            {
                string final ="";
                foreach(char alpha in value.ToLower())
                {
                    if (alpha == 'a' || alpha == 'e' || alpha == 'i' || alpha == 'o' || alpha == 'u')
                    {
                        continue;
                    }
                    else final += Convert.ToString(alpha);
                }
                Console.WriteLine(final);
                return final;
            }
            catch
            {
                string e = "Not valid";
                return e;
            }
        }
    }
}
