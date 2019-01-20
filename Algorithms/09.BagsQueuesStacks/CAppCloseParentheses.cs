using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.BagsQueuesStacks
{
    class CAppCloseParentheses
    {
        #region Constructors
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="sExp"></param>
        public CAppCloseParentheses(string sExp)
        {
            Expression = sExp;
        }

        /// <summary>
        /// Constructor
        /// </summary>
        public CAppCloseParentheses()
        {

        }
        #endregion

        #region Public Properties
        /// <summary>
        /// Expression property
        /// </summary>
        public string Expression { get; set; } = string.Empty;
        #endregion

        #region Public Methods
        /// <summary>
        /// Check if parntheses are closed or not of a given string. 
        /// Implementation is with stack
        /// </summary>
        /// <returns></returns>
        public string CloseParentheses()
        {
            string[] sBuffer = null;

            Stack<string> exprBuff = new Stack<string>();
            Stack<string> tokenBuff = new Stack<string>();

            sBuffer = Expression.Split(' ');

            for (int i = 0; i < sBuffer.Length; i++)
            {
                string currToken = sBuffer[i];

                //add numbers and operators in to char buffer stack until ')'
                if (currToken != ")")
                    tokenBuff.Push(currToken);
                else if (currToken == ")")
                {
                    //get the  token on the top of the stack
                    string firstTokenOnStack = tokenBuff.Pop();
                    int tmpRes;

                    //check if first token on the stack is number
                    if (int.TryParse(firstTokenOnStack, out tmpRes))
                    {
                        //if first token is number then pop remaining two tokens and create expression
                        if (tokenBuff.Count >= 2)
                        {
                            //first token is operand
                            string rightExp = firstTokenOnStack;

                            string opp = tokenBuff.Pop();
                            string leftExp = tokenBuff.Pop();

                            //build the expression
                            string currExp = "(" + leftExp + opp + rightExp + ")";

                            //push it on the expression buffer
                            exprBuff.Push(currExp);
                        }
                        else
                        {
                            //TODO return error
                        }
                    }
                    //the case where first token is operator
                    else
                    {
                        //first token is operator
                        string opp = firstTokenOnStack;

                        string sRightExp = exprBuff.Pop();
                        string sLeftExp = exprBuff.Pop();

                        string currExp = "(" + sLeftExp + opp + sRightExp + ")";

                        exprBuff.Push(currExp);
                    }
                }
            }

            string tmp = null;

            if (exprBuff.Count == 1)
                tmp = exprBuff.Pop();

            return tmp;
        }
        #endregion
    }
}