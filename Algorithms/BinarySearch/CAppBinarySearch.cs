using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    class CAppBinarySearch
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        private static bool BinarySearch(int[] arr, int value)
        {
            int l = 0;
            int h = arr.Length - 1;
            int pos = (h + l) / 2;
            int i = 0;
            Console.WriteLine("Init: i = {0} l = {1}, h={2}, pos = {3}, value = {4}", i, l, h, pos, value);
            while (l != h)
            {
                if (value == arr[pos])
                {
                    Console.WriteLine("Hit! i = {0} pos = {1}, value = {2}", i, pos, value);
                    return true;
                }
                if (value > arr[pos])
                    l = pos;
                else if (value < arr[pos])
                    h = pos;

                Console.WriteLine(string.Format("i= {0} | l = {1}, h = {2}, pos = {3}", i, l, h, pos));
                pos = (h + l) / 2;
                i++;
            }

            return true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="value"></param>
        /// <param name="low"></param>
        /// <param name="high"></param>
        /// <returns></returns>
        private static bool BinarySearchRec(ref int[] arr, int value, int low, int high)
        {
            int pos = (low + high) / 2;

            if (arr[pos] == value)
            {
                Console.WriteLine("Recursive Hit! pos = {0}, value = {1}", pos, value);
                return true;
            }
            else if (high < low)
                return false;
            else
            {
                if (value < arr[pos])
                    high = pos;
                else
                    low = pos;

                return BinarySearchRec(ref arr, value, low, high);
            }
        }

        private static void GenerateSortedArray(ref int[] arr, int max)
        {
            arr = new int[max];
            for (int i = 0; i < max; i++)
                arr[i] = i;
        }

        static void Main(string[] args)
        {
            int[] tmp = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            int[] tmp1= null;
            GenerateSortedArray(ref tmp1, 1000000);

            //start stopwatch
            var watch = System.Diagnostics.Stopwatch.StartNew();
            BinarySearch(tmp1, 9999);
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;

            Console.WriteLine("Execution time :{0} ms", elapsedMs);
            BinarySearch(tmp, 2);

            //execute recursive bin search
            BinarySearchRec(ref tmp, 6, 0, tmp.Length -1);

            //start stopwatch
            var watch1 = System.Diagnostics.Stopwatch.StartNew();

            //execute recursive bin search
            BinarySearchRec(ref tmp1, 9999, 0, tmp1.Length - 1);

            //get the timing
            var elapsedMs1 = watch.ElapsedMilliseconds;
            Console.WriteLine("Execution time :{0} ms", elapsedMs1);

            Console.ReadKey();
        }
    }
}
