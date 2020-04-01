using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySortedOrNot
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Define the size of the array");
            //int n = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter your values to the array");
            //int[] a = new int[n];

            //for (int i = 0; i < n; i++)
            //{
            //    a[i] = int.Parse(Console.ReadLine());
            //}

            int[] a = { 1, 3, 32, 4 };
            int n = a.Length;


            if ((n>=3 &&a[n - 1] >= a[n - 2])|| (a[n - 1] > a[n - 2]))
            {
                ArraySortedOrNot1(a, n);
                if (ArraySortedOrNot1(a, n) != 1)
                {
                    Console.WriteLine("Array is not sorted.");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Array is already sorted");
                    Console.ReadLine();
                }
            }
            else if((n >= 3 && a[n - 1] <= a[n - 2]) || (a[n - 1] < a[n - 2]))
            {
                ArraySortedOrNot2(a, n);
                if (ArraySortedOrNot2(a, n) != 1)
                {
                    Console.WriteLine("Array is not sorted.");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Array is already sorted");
                    Console.ReadLine();
                }
            }
        }


        static int ArraySortedOrNot1(int[] A, int N)
        {
            if (N == 1 || N == 0)
            {
                return 1;
            }
            else if(A[N - 1] < A[N - 2])
            {
                return 0;
            }
            else
            {
                return ArraySortedOrNot1(A, N - 1);
            }
        }


        static int ArraySortedOrNot2(int[] A, int N)
        {
            if (N == 1 || N == 0)
            {
                return 1;
            }
            else if (A[N - 1] > A[N - 2])
            {
                return 0;
            }
            else
            {
                return ArraySortedOrNot2(A, N - 1);
            }
        }
    }
}
