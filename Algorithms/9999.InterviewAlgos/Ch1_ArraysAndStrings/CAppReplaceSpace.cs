using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9999.InterviewAlgos.Ch1_ArraysAndStrings
{
    class CAppReplaceSpace
    {
        /// <summary>
        /// Write a method to replace all spaces in a string with '%20' 
        /// You may assume that the string
        /// has sufficient space at the end of the string to hold the additional characters, 
        /// and that you are given the "true" length of the string. 
        /// (Note: if implementing in Java, please use a characters
        /// array so that you can perform this operation in place)
        /// </summary>
        /// <param name="strBuffer"></param>
        /// <returns></returns>
        public char[] ReplaceSpace(char[] strBuffer)
        {
            //count space
            int n = strBuffer.Length;
            int iSpaceCount = 0;
            for (int i = 0; i < n; i++)
            {
                if (strBuffer[i] == ' ')
                    iSpaceCount++;
            }

            char[] newBuffer = new char[n + (iSpaceCount * 3)];

            int j = 0;
            for (int i = 0; i < n; i++)
            {
                if (strBuffer[i] == ' ')
                {
                    newBuffer[j++] = '%';
                    newBuffer[j++] = '2';
                    newBuffer[j++] = '0';
                }
                else
                {
                    newBuffer[j++] = strBuffer[i];
                }
            }

            return newBuffer;
        }

        public static void Check()
        {
            string str1 = "test sf asdf sdfff asdf";
            CAppReplaceSpace rs = new CAppReplaceSpace();

            string result = string.Concat(rs.ReplaceSpace(str1.ToCharArray()));
            Console.WriteLine("Original: {0}, replaced : {1}", str1, result);
        }
    }
}
