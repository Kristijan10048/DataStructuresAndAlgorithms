using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9999.InterviewAlgos
{
    class CAppPalindrome
    {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="arr"></param>
        /// <returns></returns>
        public bool Check<T>(ref T[] arr) where T : IComparable
        {
            int n = arr.Length;
            int i = 0;
            int j = n - 1;
            while(i <= n/2)
            {
                if (arr[i].CompareTo(arr[j]) != 0)
                    return false;
                i++;
                j--;
            }

            return true;
        }
    }
}
