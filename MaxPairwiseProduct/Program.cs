using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxPairwiseProduct
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] a = { 2, 4, 4 };
            long n = a.Length;
            long result = 1;
            if (n >= 3)
            {
                MaxPairWiseProduct(a, n, result);
            }
            else if (n == 2)
            {
                Console.WriteLine(a[n - 1] * a[n - 2]);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(result * a[n - 1]);
                Console.ReadLine();
            }
        }

        static long MaxPairWiseProduct(long[] A, long N, long Result)
        {
            

            return MaxPairWiseProduct(A, N - 1, Result);
        }
    }
}
