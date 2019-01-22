using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.BagsQueuesStacks
{
    class CAppDecToBinWithStack
    {
        #region Private Members
        private int m_numb;

        #endregion

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="number"></param>
        public CAppDecToBinWithStack(int number)
        {
            m_numb = number;
        }

        /// <summary>
        /// Convert integer decade to binary representation
        /// </summary>
        /// <param name="number">A number to convert</param>
        /// <returns>String representation</returns>
        public string ToBin(int number)
        {
            Stack<int> stackBuff = new Stack<int>();
            
            while (number != 0)
            {
                stackBuff.Push(number % 2);
                number /= 2;
            }

            string output = string.Empty;
            while( stackBuff.Count > 0)
            {
                output += stackBuff.Pop();
            }
            return output;
        }

        public string ToBin()
        {
            return ToBin(m_numb);
        }

        public int Number
        {
            get { return m_numb; }

        }
    }
}
