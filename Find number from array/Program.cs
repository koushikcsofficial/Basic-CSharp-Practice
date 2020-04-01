using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_number_from_array
{
    class Program
    {
        static void Main(string[] args)
        {

            int arrCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = new List<int>();

            for (int i = 0; i < arrCount; i++)
            {
                int arrItem = Convert.ToInt32(Console.ReadLine().Trim());
                arr.Add(arrItem);
            }

            int k = Convert.ToInt32(Console.ReadLine().Trim());

            string res = findNumber(arr, k);
            Console.WriteLine(res);
            Console.ReadLine();
        }

        private static string findNumber(List<int> arr, int k)
        {
            if (arr.Contains(k))
            {
                return "Yes";
            }
            else
            {
                return "No";
            }
        }
    }
}
