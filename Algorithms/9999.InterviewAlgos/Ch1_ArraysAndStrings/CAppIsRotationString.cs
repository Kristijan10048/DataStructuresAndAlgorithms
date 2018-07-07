using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9999.InterviewAlgos.Ch1_ArraysAndStrings
{
    class CAppIsRotationString
    {
        private string RotateToRight(string arg)
        {
            char[] tmpBuff = new char[arg.Length];
            for (int i = 0; i < arg.Length; i++)
            {
                if (i + 1 == arg.Length)
                    tmpBuff[0] = arg[i];
                else
                    tmpBuff[i + 1] = arg[i];
                //  Swap(ref tmpBuff, i, i + 1);

                // Console.WriteLine("Tmp buff: {0}", string.Concat(tmpBuff));
            }

            return string.Concat(tmpBuff);
        }

        public bool Check(string arg, string argTarget)
        {
            Console.WriteLine("Original input : {0}, shifted : {1}", arg, RotateToRight(arg));
            int i = 1;
            int noOfRotations = arg.Length;
            while (i <= noOfRotations)
            {
                string tmpStr = RotateToRight(arg);
                if (tmpStr == argTarget)
                {
                    Console.WriteLine("Match original {0} with {1}", arg, tmpStr);
                    return true;
                }
                i++;
            }

            return false;
        }

        public bool CheckAgain(string s1, string s2)
        {
            int len = s1.Length;

            /*check that s1 and s2 are equal length and not empty */
            if (len == s2.Length && len > 0)
            {
                /* concatenate s1 and s1 within new buffer */
                string s1s1 = s1 + s1;

                //substring
                return s1s1.Contains(s2);
            }

            return false;
        }
    }
}
