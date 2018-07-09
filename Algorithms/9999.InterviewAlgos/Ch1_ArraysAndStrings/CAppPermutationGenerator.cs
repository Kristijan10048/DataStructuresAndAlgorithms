using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9999.InterviewAlgos.Ch1_ArraysAndStrings
{
    class CAppPermutationGenerator
    {
        #region Private Members
        private List<string> m_buffer = null;
        #endregion

        #region Constructors
        public CAppPermutationGenerator()
        {
            m_buffer = new List<string>();
        }
        #endregion

        #region Private Util Methods
        /// <summary>
        /// 
        /// </summary>
        /// <param name="str"></param>
        /// <param name="iPos"></param>
        /// <param name="jPos"></param>
        /// <param name="indent"></param>
        private void Swap(ref string str, int iPos, int jPos, string indent)
        {

            char[] buff = str.ToCharArray();
            Console.WriteLine(indent + "Swap input : {0}", str);
            Console.WriteLine(indent + "Swap {0} with {1}", buff[iPos], buff[jPos]);
            char tmp = buff[iPos];
            buff[iPos] = buff[jPos];
            buff[jPos] = tmp;

            str = string.Concat(buff);
        }

        /// <summary>
        /// Generates all possible permutations from input string
        /// </summary>
        /// <param name="sInpChars"></param>
        private void GeneratePermutations(int n, ref string sInpChars, string indent)
        {
            Console.WriteLine(indent + "-----------------------------");
            Console.WriteLine(indent + "Call GenPer n = {0}, string = {1}", n, sInpChars);
            if (n == 1)
            {

                Console.WriteLine(indent + "Exit GenPerm  {0}", sInpChars);
                m_buffer.Add(sInpChars);
                return;
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine(indent + "i = {0}", i);
                    Swap(ref sInpChars, i, n - 1, indent);

                    GeneratePermutations(n - 1, ref sInpChars, indent + "\t");

                    Swap(ref sInpChars, i, n - 1, indent);
                }

            }
        }

        #endregion

        #region Public Properties
        public string[] Permutations
        {
            get
            {
                string[] tmpBuff = new string[m_buffer.Count];

                for (int i = 0; i < m_buffer.Count; i++)
                    tmpBuff[i] = m_buffer[i];

                return tmpBuff;
            }

        }

        public List<string> Permutatons
        {
            get { return m_buffer; }
        }
        #endregion

        public static void Check()
        {
            string sInput = "1234";
            int n = sInput.Length;

            CAppPermutationGenerator gen = new CAppPermutationGenerator();

            gen.GeneratePermutations(n, ref sInput, "");

            int i = 1;
            foreach (string s in gen.Permutations)
            {
                Console.WriteLine("{1}, Permutation: {0}", s, i);
                i++;
            }
        }

        /// <summary>
        ///  Given two strings, write a method to decide if one is a permutation of the other
        /// </summary>
        /// <param name="sStr1"></param>
        /// <param name="sStr2"></param>
        public static void CheckPermutationsMk1BruteForce(string sStr1, string sStr2)
        {
            if (sStr1 == null || sStr1.Length == 0 || sStr2 == null || sStr2.Length == 0)
            {
                Console.WriteLine("Empty string!");
                return;
            }
            else
            if (sStr1.Length != sStr2.Length)
            {
                Console.WriteLine("String lengths don't match!");
                return;
            }
            else
            {
                CAppPermutationGenerator gen = new CAppPermutationGenerator();

                int n = sStr1.Length;
                gen.GeneratePermutations(n, ref sStr1, "");

                if (gen.Permutations.Contains<string>(sStr2))
                    Console.WriteLine("String {0} is permutation of {1}", sStr1, sStr2);
                else
                    Console.WriteLine("String {0} is not permutation of {1}", sStr1, sStr2);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sStr1"></param>
        /// <param name="sStr2"></param>
        public static void CheckPermutationsMk2(string sStr1, string sStr2)
        {
            if (sStr1 == null || sStr1.Length == 0 || sStr2 == null || sStr2.Length == 0)
            {
                Console.WriteLine("Empty string!");
                return;
            }
            else
            if (sStr1.Length != sStr2.Length)
            {
                Console.WriteLine("String lengths don't match!");
                return;
            }
            else
            {
                int n = sStr1.Length;
                int i = 0;
                Hashtable buffer = new Hashtable();
                while (i < n)
                {

                    char chS1 = sStr1[i];
                    char chS2 = sStr2[i];
                    if (!buffer.Contains(chS1.GetHashCode()))
                    {
                        buffer.Add(chS1.GetHashCode(), chS1);
                    }
                    else if (buffer.Contains(chS1.GetHashCode()))
                    {
                        buffer.Remove(chS1.GetHashCode());
                    }


                    if (!buffer.Contains(chS2.GetHashCode()))
                    {
                        buffer.Add(chS2.GetHashCode(), chS2);
                    }
                    else if (buffer.Contains(chS2.GetHashCode()))
                    {
                        buffer.Remove(chS2.GetHashCode());
                    }

                    i++;
                }

                Console.WriteLine("---------------------Check permutations mk2------------------------------");

                Console.WriteLine("Buffer count {0}", buffer.Count);
                foreach (char ch in buffer.Values)
                    Console.WriteLine("Char : {0}", ch);

                if (buffer.Count == 0)
                    Console.WriteLine("String {0} is permutation of {1}", sStr1, sStr2);
                else
                    Console.WriteLine("String {0} is not permutation of {1}", sStr1, sStr2);
            }

        }
    }
}
