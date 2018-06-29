using System;


namespace Histogram
{
    class CAppHistogram
    {


        /// <summary>
        ///Write a static method histogram() that takes an array a[] of int values and
        ///an integer M as arguments and returns an array of length M whose ith entry is the number
        ///of times the integer i appeared in the argument array.If the values in a[] are all
        ///between 0 and M–1, the sum of the values in the returned array should be equal to
        ///a.length.
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="m"></param>
        /// <returns></returns>
        private static int[] Histogram(ref int[] arr, int m)
        {
            int[] buff = new int[m];
            int i;

            //init buff to 0;
            for (i = 0; i < m; i++)
                buff[i] = 0;

            for (int j = 0; j < arr.Length; j++)
            {
                if (arr[j] < m)
                    buff[arr[j]]++;
            }

            return buff;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="arr"></param>
        private static void PrintArray(ref int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + ", ");
        }

        static void Main(string[] args)
        {
            //test data
            int[] temp = { 1, 1, 1, 2, 2, 0, 0, 5, 5, 5, 6, 7, 9, 10, 10, 1 };
            int m = 10;

            Console.Write("Input arr : ");
            PrintArray(ref temp);
            Console.WriteLine();


            int[] tmpHist = Histogram(ref temp, m);

            Console.Write("Hist : ");
            PrintArray(ref tmpHist);


            Console.ReadKey();
        }
    }
}
