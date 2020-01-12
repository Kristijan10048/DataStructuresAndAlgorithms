using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    class Program
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        public static void CountDuplicates(int[] a)
        {
            int n = a.Length;
            List<int> tmp = new List<int>();
            for (int i = 0; i < n; i++)
                if (!tmp.Contains(a[i]))
                    tmp.Add(a[i]);

            int duplNo = a.Length - tmp.Count;

            Console.WriteLine("Number of duplicates {0}",duplNo);


        }

        static void Main(string[] args)
        {
            IComparable a = 10, b = 4;
            Console.WriteLine("{0}.CompareTo({1}) = {2}", a, b, a.CompareTo(b));

            a = 3; b = 11;
            Console.WriteLine("{0}.CompareTo({1}) = {2}", a, b, a.CompareTo(b));

            a = 3; b = 3;
            Console.WriteLine("{0}.CompareTo({1}) = {2}", a, b, a.CompareTo(b));


            int[] arr = { 1, 2, 2, 2, 3, 2, 4, 5, 6, 7, 7, 7, 6, 5, 8 };
            CountDuplicates(arr);
            Console.ReadKey();
        }
    }
}
