using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.BagsQueuesStacks
{
    //    Write a stack client Parentheses that reads in a text stream from standard input
    //and uses a stack to determine whether its parentheses are properly balanced.For example,
    //your program should print true for [()]{ }{[()()]()} and false for [(]).
    class CAppParenthesesChecker
    {
        #region Private Members
        private string m_sExpr;
        #endregion

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sExpr"></param>
        public CAppParenthesesChecker(string sExpr)
        {
            m_sExpr = sExpr;
        }

        public bool CheckExpression()
        {
            Stack<char> tmpBuff = new Stack<char>();
            for (int i = 0; i < m_sExpr.Length; i++)
            {
                char currChar = m_sExpr[i];
                if ((currChar == '(') ||
                     (currChar == '[') ||
                     (currChar == '{'))
                {
                    tmpBuff.Push(currChar);
                }
                else

                if ((currChar == ')') ||
                     (currChar == ']') ||
                     (currChar == '}'))
                {
                    char onStack = (char)tmpBuff.Pop();

                    if (onStack == '(' && currChar == ')')
                        continue;
                    else if (onStack == '[' && currChar == ']')
                        continue;
                    else if (onStack == '{' && currChar == '}')
                        continue;
                    else
                        return false;
                }
            }

            return true;
        }

        public string Expression
        {
            get { return m_sExpr; }
            set { m_sExpr = value; }
        }
    }
}