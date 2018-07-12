using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9999.InterviewAlgos.CompanyInterview
{

    /// <summary>
    /// Given an array of size n, find the majority element. 
    /// The majority element is the element that appears more than ⌊ n/2 ⌋ times.
    /// You may assume that the array is non-empty and the majority element always exist in the array.
    /// </summary>
    class CAppMajorityElement
    {
        public static void MajorityElement(int[] arr)
        {
            int[] tmpArr = new int[arr.Length];
            int n = arr.Length;

            for (int i = 0; i < n; i++)
            {
                int currValue = arr[i];
                tmpArr[currValue]++;
            }

            int maxPos = 0;
            int maxVal = 0;
            for(int i =0; i< n; i++)
            {
                if (tmpArr[i] > n / 2 && tmpArr[i] > maxPos)
                {
                    maxPos = tmpArr[i];
                    maxVal = i;
                }
            }

            Console.WriteLine("Majority element is {0} ", maxVal);
        }

        public static void  Check()
        {
            int[] testArr = { 1, 1, 1, 1, 1, 2, 3 };

            MajorityElement(testArr);
        }
    }
}
