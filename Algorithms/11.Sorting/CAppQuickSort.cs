using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Sorting
{
    class CAppQuickSort
    {
        #region Private Methods
        private void Print<T>(ref T[] arr, string indent) where T : IComparable
        {
            Console.Write(indent);
            foreach (T el in arr)
                Console.Write("{0}, ", el);

            Console.WriteLine();
        }

        /// <summary>
        /// Swap two elements
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="i"></param>
        /// <param name="j"></param>
        private void Swap<T>(ref T[] arr, int i, int j, string indent) where T : IComparable
        {
            Console.WriteLine(indent + "Swap {0} with {1}", i, j);

            T tmp = arr[i];
            arr[i] = arr[j];
            arr[j] = tmp;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        private bool Less(IComparable a, IComparable b)
        {
            //descending order
            //return a.CompareTo(b) == 1;

            //ascending order
            return a.CompareTo(b) == -1;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="lo"></param>
        /// <param name="hi"></param>
        /// <returns></returns>
        private int Partition<T>(ref T[] a, int lo, int hi, string indent) where T : IComparable
        {
            // Partition into a[lo..i-1], a[i], a[i+1..hi].

            // left and right scan indices
            int iStart = lo, jEnd = hi + 1;

            // partitioning item
            IComparable v = a[lo];
            Console.WriteLine(indent + "--Call Partition(arr, {0}, {1})", lo, hi);

            while (true)
            {
                // Scan right, scan left, check for scan complete, and exchange.
                while (Less(a[++iStart], v))
                    if (iStart == hi) break;

                while (Less(v, a[--jEnd]))
                    if (jEnd == lo) break;

                if (iStart >= jEnd)
                    break;
                Swap(ref a, iStart, jEnd, indent);
            }

            // Put v = a[j] into position
            Swap(ref a, lo, jEnd, indent);

            Console.WriteLine(indent + "--End: Call Partition()");

            // with a[lo..j-1] <= a[j] <= a[j+1..hi].
            return jEnd;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="lo"></param>
        /// <param name="hi"></param>
        private void Sort<T>(ref T[] a, int lo, int hi, string indent) where T : IComparable
        {
            if (hi <= lo)
                return;

            Console.WriteLine(indent + "--Call Sort(arr, {0}, {1})", lo, hi);
            Print(ref a, indent);

            // Partition (see page 291).
            int j = Partition(ref a, lo, hi, indent);
            
            Console.WriteLine(indent + "J = {0}, low = {1}, high = {2}", j, lo, hi);
            Print(ref a, indent);

            // Sort left part a[lo .. j-1].
            Sort(ref a, lo, j - 1, indent + "\t");

            // Sort right part a[j+1 .. hi].
            Sort(ref a, j + 1, hi, indent+ "\t");

            

            Console.WriteLine(indent + "--End call Sort(arr, {0}, {1})", lo, hi);
            Console.WriteLine(indent + "*****************************");
        }
        #endregion


        #region Public Methods
        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        public void Sort<T>(ref T[] a) where T : IComparable
        {
            // Eliminate dependence on input.
            //StdRandom.shuffle(a); 

            Sort(ref a, 0, a.Length - 1, "\t");
        }
        #endregion
    }
}
