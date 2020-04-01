using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program1
    {
        static void Main(string[] args)
        {
            string name = "Koushik564";
            IList<string> num = new List<string>();
            IList<string> names = new List<string>();
            foreach (char c in name.Trim())
            {
                if (c == '0' || c == '1' || c == '2' || c == '3' || c == '4' || c == '5' || c == '6' || c == '7' || c == '8' || c == '9')
                {
                    num.Add(c.ToString());
                }
                else names.Add(c.ToString());
            }
            //foreach (string item in num) Console.Write(item);
            //Console.WriteLine("\n");
            //foreach (string item in names) Console.Write(item);
            Console.WriteLine("\n");
            if (num.Count > 0 && names.Count>0 && Convert.ToInt32(num[0])%2 is 0)
            {
                if (num.Count == names.Count)
                {
                    for(int i=0; i <= num.Count; i++)
                    {
                        Console.Write(num[i]+ names[i]);
                    }
                }
                if (num.Count> names.Count)
                {
                    int i = 0;
                    while (i < names.Count)
                    {
                        Console.Write(num[i] + names[i]);
                        i++;                     
                    }
                    while (i < num.Count) {
                        Console.Write(num[i]);
                        i++;
                    }
                }
                if (num.Count < names.Count)
                {
                    int i = 0;
                    while (i < num.Count)
                    {
                        Console.Write(num[i]+ names[i]);
                        i++;
                    }
                    while (i < names.Count) {
                        Console.Write(names[i]);
                        i++;
                    } 
                }
            }
            else if (num.Count>0 && names.Count>0 && Convert.ToInt32(num[0]) % 2 is 1)
            {
                if (num.Count == names.Count )
                {
                    for (int i = 0; i <= num.Count; i++)
                    {
                        Console.Write(names[i]+num[i]);
                    }
                }
                if (num.Count > names.Count)
                {
                    int i = 0;
                    while (i < names.Count)
                    {
                        Console.Write(names[i]+num[i]);
                        i++;
                    }
                    while (i < num.Count) {
                        Console.Write(num[i]);
                        i++;
                    } 
                }
                if (num.Count < names.Count)
                {
                    int i = 0;
                    while (i < num.Count)
                    {
                        Console.Write(names[i] + num[i]);
                        i++;
                    }
                    while (i < names.Count)
                    {
                        Console.Write(names[i]);
                        i++;
                    }
                }

            }
            else
            {
                if(num.Count is 0 && names.Count is 0)
                {
                    Console.WriteLine("Nothing found in the string");
                }else if (num.Count>0 && names.Count is 0)
                {
                    foreach(string item in num)
                    {
                        Console.Write(item);
                    }
                }
                else
                {
                    foreach (string item in names)
                    {
                        Console.Write(item);
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
