using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int l = Convert.ToInt32(Console.ReadLine().Trim());

            int r = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> res = oddNumbers(l, r);

            Console.WriteLine(String.Join("\n", res));
            Console.ReadLine();
        }

        private static List<int> oddNumbers(int l, int r)
        {
            if(l%2==0 & r % 2 == 0)
            {
                List<int> odd = new List<int>();
                for(int i = l+1; i<=r-1; i+=2)
                {
                    odd.Add( i);
                }
                return odd;
            }
            else if(l%2==0 && r%2 !=0)
            {
                List<int> odd = new List<int>();
                for (int i = l + 1; i <= r; i+=2)
                {
                    odd.Add(i);
                }
                return odd;
            }
            else if (l % 2 !=0 && r % 2==0)
            {
                List<int> odd = new List<int>();
                for (int i = l; i <= r;i+=2)
                {
                    odd.Add(i);
                }
                return odd;
            }
            else
            {
                List<int> odd = new List<int>();
                for (int i = l; i <= r ; i+=2)
                {
                    odd.Add(i);
                }
                return odd;
            }
        }
    }
}
