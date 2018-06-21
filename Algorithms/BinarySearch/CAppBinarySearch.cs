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
        static void Main(string[] args)
        {
            int[] tmp = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            BinarySearch(tmp, 6);
            BinarySearch(tmp, 2);

            Console.ReadKey();
        }
    }
}
