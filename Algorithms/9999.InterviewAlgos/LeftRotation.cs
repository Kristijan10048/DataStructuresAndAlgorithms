using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9999.InterviewAlgos
{
    class LeftRotation
    {
        static int[] LeftTotattion(int[] arr, int d)
        {
            //length of the array
            int n = arr.Length;
            int[] tmp = new int[2 * n];

            

            int k = 0;
            //copy the array 2x times 1,2,3,1,2,3
            for (int j = 0; j < 2 * n; j++)
            {
                if (k >= n)
                    k = 0;

                tmp[j] = arr[k];
                k++;
            }

            int[] res = new int[n];

            if (d > n)
                d = d - n;

            k = 0;
            for (int i = d; i < d + n; i++)
            {
                res[k] = tmp[i];
                k++;
            }

            return res;
        }
    }
}
