using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9999.InterviewAlgos.Ch1_ArraysAndStrings
{
    class CAppIsUniqueChars
    {
        /// <summary>
        /// Checks if all characters are unique in given string
        /// </summary>
        /// <param name="sArg"></param>
        /// <returns></returns>
        public bool Check(string sArg)
        {
            for(int i = 0; i<sArg.Length; i++)
            {
                for(int j=i+1; j<sArg.Length; j++)
                {
                    if (sArg[i] == sArg[j])
                        return false;
                }
            }

            return true;
        }

        public bool CheckAgain(string str)
        {
            int checker = 0;
            for (int i = 0; i < str.Length; i++)
            {
                int val = str[i] - 'a';
                if ((checker & (1 << val)) > 0)
                {
                    return false;
                }
                checker |= (1 << val);
            }
            return true;
        }
    }
}
