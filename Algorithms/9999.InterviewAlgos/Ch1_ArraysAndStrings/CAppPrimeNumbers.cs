using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9999.InterviewAlgos.Ch1_ArraysAndStrings
{
    class CAppPrimeNumbers
    {
        /// <summary>
        /// Finds prime numbers and prints them
        /// </summary>
        public static void PrimeNumbers()
        {
            int n = 1000;
            for (int i = 1; i < n; i++)
            {
                int iCurrNumber = i;
                bool isPrime = true;
                for (int j = 2; j <= iCurrNumber / 2; j++)
                {
                    if (iCurrNumber % j == 0)
                    {
                        isPrime = false;
                        break;
                    }                    

                }

                if (isPrime)
                    Console.WriteLine("Number {0} is prime!", iCurrNumber);
            }
        }
    }
}
