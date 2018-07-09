using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Sorting
{
    class CAppSorting
    {
        #region Sorting Algorithms
        /// <summary>
        /// One of the simplest sorting algorithms works as follows: First, find
        /// the smallest item in the array and exchange it with the first entry(itself if the first entry
        /// is already the smallest). Then, find the next smallest item and exchange it with the second
        /// entry.Continue in this way until the entire array is sorted.This method is called
        /// selection sort because it works by repeatedly selecting the smallest remaining item.
        /// </summary>
        /// <param name="arr"></param>
        private static void SelectionSort(ref int[] arr)
        {
            int min = arr[0];
            int n = arr.Length;
            for (int i = 0; i < n; i++)
            {
                min = arr[i];
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < min)
                    {
                        //swap minimum
                        min = arr[j];
                        arr[j] = arr[i];
                        arr[i] = min;
                    }
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="arr"></param>
        private static void InsertionSort(ref int[] arr)
        {
            int tmp;
            for (int i = 1; i < arr.Length; i++)
            {
                for (int j = i; j > 0 && arr[j] < arr[j - 1]; j--)
                {
                    //if current element a[j] is smaller then previous one
                    //swap the positions      
                    {
                        tmp = arr[j];
                        arr[j] = arr[j - 1];
                        arr[j - 1] = tmp;

                    }
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="arr"></param>
        public static void ShellSort(ref int[] arr)
        { // Sort a[] into increasing order.
            int N = arr.Length;

            int h = 1;
            while (h < N / 3)
                h = 3 * h + 1; // 1, 4, 13, 40, 121, 364, 1093, ...

            int counter = 0;

            while (h >= 1)
            {
                Console.WriteLine("h: {0}", h);
                PrintArr(ref arr);
                Console.WriteLine("-------------------------");

                // h-sort the array.
                for (int i = h; i < N; i++)
                {
                    Console.WriteLine("i : {0}, h: {1}", i, h);

                    // Insert a[i] among a[i-h], a[i-2*h], a[i-3*h]... .
                    for (int j = i; j >= h && arr[j] < arr[j - h]; j -= h)
                    {
                        Console.WriteLine("i : {0}, h: {1}, j: {2}, swap: {3} and {4} at pos {5}, {6}", i, h, j, arr[j - h], arr[j], j - h, j);
                        int tmp = arr[j];
                        arr[j] = arr[j - h];
                        arr[j - h] = tmp;

                        Console.WriteLine("*******************************");
                        PrintArr(ref arr);
                    }

                }
                h = h / 3;
            }
        }
        #endregion

        /// <summary>
        /// 
        /// </summary>
        /// <param name="arr"></param>
        static void PrintArr(ref int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                Console.Write("{0}, ", arr[i]);
            Console.Write("\n");
        }

        /// <summary>
        /// 
        /// </summary>
        static void InsertionVsSelection()
        {
            const int n = 100000;
            Random rnd = new Random();
            int[] arr = new int[n];
            int[] arr1 = new int[n];
            for (int k = 0; k < 10; k++)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = rnd.Next(1000);
                    arr1[i] = arr[i];
                }

                Console.WriteLine("Experiment no. {0}", k + 1);
                {
                    var watch = System.Diagnostics.Stopwatch.StartNew();
                    ShellSort(ref arr);
                    watch.Stop();
                    var elapsedMs = watch.ElapsedMilliseconds;
                    Console.WriteLine("Insertion sort time : {0}ms", elapsedMs);
                }
                {
                    var watch1 = System.Diagnostics.Stopwatch.StartNew();
                    SelectionSort(ref arr1);
                    watch1.Stop();
                    var elapsedMs1 = watch1.ElapsedMilliseconds;
                    Console.WriteLine("Selection sort time : {0}ms", elapsedMs1);
                }
                Console.WriteLine("----------------------");

            }
        }

        static void Main(string[] args)
        {
            //const int n = 25;
            //Random rnd = new Random();
            //int[] arr = new int[n];
            //for (int i = 0; i < arr.Length; i++)
            //    arr[i] = rnd.Next(21);
            //Console.WriteLine("Array before sorting:");
            //PrintArr(ref arr);
            //Console.WriteLine("----------------------");
            //Console.WriteLine("Array after sorting:");
            //ShellSort(ref arr);
            //PrintArr(ref arr);
            //Console.WriteLine("----------------------");
            //int k = 0;
            //for (int i = 0; i < 5; i++)
            //    Console.WriteLine("K : {0}", k++);
            //InsertionVsSelection();

            TestQuickSort();

            Console.WriteLine("Press any key to end...");
            Console.ReadKey();
        }

        private static void TestMergeSort()
        {
            const int n = 25;
            Random rnd = new Random();
            int[] arr = new int[n];

            for (int i = 0; i < arr.Length; i++)
                arr[i] = rnd.Next(21);


            CAppMergeSort mergeS = new CAppMergeSort();


            mergeS.TopDownMergeSort(ref arr);

            PrintArr(ref arr);
        }

        private static void TestQuickSort()
        {
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Quick sort");

            CAppQuickSort qs = new CAppQuickSort();
            const int C_MAX_RND = 100;
            Random rnd = new Random();


            int[] arr = { 0, 1, 2, 3, 1, 4, 5, 6, 1 };//= new int[10];

            //for (int i = 0; i < arr.Length; i++)
            //    arr[i] = rnd.Next(C_MAX_RND);

            Console.WriteLine("Before quick sort:");
            PrintArr(ref arr);
            qs.Sort(ref arr);
            Console.WriteLine("After quick sort:");
            PrintArr(ref arr);
            Console.WriteLine("-----------------------------------");
        }
    }
}
