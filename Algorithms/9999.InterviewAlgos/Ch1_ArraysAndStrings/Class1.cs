using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9999.InterviewAlgos.Ch1_ArraysAndStrings
{
    class CAppMatchStriings
    {


        // Complete the minimumSwaps function below.
        static int minimumSwaps(int[] arr)
        {
            int swaps = 0;
            int n = arr.Length;

            for (int i = 0; i < n; i++)
            {
                int currVal = arr[i];

                if (Math.Abs(currVal - (i + 1)) > 0)
                {
                    int tmp = arr[currVal];
                    arr[currVal] = arr[i];
                    arr[i] = tmp;
                    swaps++;
                }
                //i--;
            }


            return swaps;
        }

        // Complete the minimumBribes function below.
        static void minimumBribes(int[] q)
        {
            int n = q.Length;

            int[] refArr = new int[n];
            for (int i = 0; i < n; i++)
            {
                refArr[i] = i + 1;
            }

            int[] res = new int[n];
            
            for (int i = 0; i < n; i++)
            {
                int tmp = q[i] - refArr[i];
                if (tmp > Math.Abs(2))
                {
                    Console.WriteLine("Too chaotic");
                    return;
                }                
            }

            int swaps = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = i; j < n; j++)
                    if (q[i] > q[j])
                    {
                        int ltmp = q[i];
                        q[i] = q[j];
                        q[j] = ltmp;
                        swaps++ ;
                    }
            }
            Console.WriteLine(swaps);
        }

        // Complete the matchingStrings function below.
        static int[] matchingStrings(string[] strings, string[] queries)
        {

            int qn = queries.Length;
            int sn = strings.Length;

            int[] match = new int[queries.Length];
            int mi = 0;
            for (int i = 0; i < qn; i++)
            {
                for (int j = 0; j < sn; j++)
                {
                    if (strings[j] == queries[i])
                        match[mi]++;
                }
                mi++;
            }

            return match;
        }
    }
}
