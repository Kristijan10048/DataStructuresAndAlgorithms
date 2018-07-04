using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Sorting
{
    class CAppMergeSort
    {

        #region Private Methods
        /// <summary>
        /// 
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="low"></param>
        /// <param name="mid"></param>
        /// <param name="high"></param>
        private void Merge(ref int[] arr, int low, int mid, int high)
        {
            Console.WriteLine("Merge: {0}, {1}, {2}", low, mid, high);
            //int n = arr.Length;
            int[] tmpArr = new int[arr.Length];

            //1 copy to tmp array
            for (int i = low; i <= high; i++)
            {
                tmpArr[i] = arr[i];
                arr[i] = -1;
            }

            //set i to low
            int iLow = low;


            //set j to mid
            int jMid = mid + 1;
            //left half exhausted (take from the right), 
            //right half exhausted(take from the left), 
            //current key on right less than current key on left(take from the right), 
            //and current key on right greater than or equal to current key on left(take from the left)
            for (int k = low; k <= high; k++)
            {
                //counter above mid then use jMid counter
                if (iLow > mid)
                    arr[k] = tmpArr[jMid++];

                //counter above high then use iLow counter
                else if (jMid > high)
                    arr[k] = tmpArr[iLow++];

                //if middle half element is smaller then low half
                //then copy elements from middle half
                else if (tmpArr[jMid] < tmpArr[iLow])
                    arr[k] = tmpArr[jMid++];

                //copy the content of the first half of the array
                else
                    arr[k] = tmpArr[iLow++];
            }
        }
        #endregion

        #region Public Methods
        /// <summary>
        /// 
        /// </summary>
        /// <param name="arr"></param>
        public void TopDownMergeSort(ref int[] arr)
        {
            int n = arr.Length - 1;

            TopDownMergeSort(ref arr, 0, n);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="arr"></param>
        private void TopDownMergeSort(ref int[] arr, int low, int high)
        {
            int middle = low + (high - low) / 2;
            if (high < low || high == low)
                return;


            Console.WriteLine("Call {0} , {1}, {2}", low, middle, high);
            for (int i = 0; i < arr.Length; i++)
                Console.Write("{0}, ", arr[i]);

            Console.WriteLine();

            TopDownMergeSort(ref arr, low, middle);
            TopDownMergeSort(ref arr, middle + 1, high);
            Merge(ref arr, low, middle, high);
        }
        #endregion

    }
}
