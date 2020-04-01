using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insertion_sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 3, 2 };
            InsertionSort(a);
        }
        static void InsertionSort(int[] A)
        {
            for(int j =1; j <= A.Length - 1; j++)
            {
                int key = A[j];
                int i = j - 1;
                while(i>0 && A[i] > key)
                {
                    A[i + 1] = A[i];
                    i = i - 1;
                }
                A[i + 1] = key;
            }
            for (int i = 0; i < A.Length; ++i)
                Console.Write(A[i] + " ");
            Console.ReadLine();
        }
    }
}
