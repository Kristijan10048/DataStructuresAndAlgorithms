using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9999.InterviewAlgos.CompanyInterview
{
    class CAppSumOfDigits
    {
        /// <summary>
        ///    //For example:
        ///Given num = 38, the process is like: 3 + 8 = 11, 1 + 1 = 2. Since 2 has only one digit, return it.
        ///Follow up:
        ///Could you do it without any loop/recursion in O(1) runtime?
        /// </summary>
        static public  void SumOfDigits()
        {
            string sArg = "38";
            Console.WriteLine("Argument : {0}", sArg);
            int iSum = 0;
            do
            {
                for (int i = 0; i < sArg.Length; i++)
                {
                    iSum += int.Parse(sArg[i].ToString());
                }

                Console.WriteLine("Curr sum : {0}", iSum);

                if (iSum < 10)
                {
                    Console.WriteLine("Sum is :{0}", iSum);
                    return;
                }

                sArg = iSum.ToString();
                iSum = 0;
            }
            while (true);
        }

        static public void SumOfDigitsRec(string sArg)
        {
            int iSum =0;

            for(int i =0; i< sArg.Length; i++)
            {
                iSum += int.Parse(sArg[i].ToString());
            }

            Console.WriteLine("Rec Arg {0}, sum {1}", sArg, iSum);

            if(iSum > 10)
            {
                SumOfDigitsRec(iSum.ToString());
            }
        }


        public static void Check()
        {
            SumOfDigits();

            SumOfDigitsRec("38");
        }
    }
}
