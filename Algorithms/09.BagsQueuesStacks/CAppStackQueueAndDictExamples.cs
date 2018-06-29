using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.BagsQueuesStacks
{
    class CAppStackQueueAndDictExamples
    {
        #region Private Static Methods
        /// <summary>
        /// Ilustrate queue 
        /// </summary>
        private static void QueueExample()
        {
            Console.WriteLine("--------Queue----------");

            //create new queue FIRST IN LAST OUT  
            var myQueue = new Queue<int>();

            //add items in the queue
            myQueue.Enqueue(1);
            myQueue.Enqueue(2);
            myQueue.Enqueue(3);
            myQueue.Enqueue(4);
            myQueue.Enqueue(5);

            //print the queue
            for (int i = 0; i < myQueue.Count; i++)
                Console.WriteLine(myQueue.ElementAt<int>(i));

            int tmpVal = myQueue.Dequeue();
            Console.WriteLine("------------------");
            Console.WriteLine("Dequeue {0}", tmpVal);
            Console.WriteLine("------------------");

            for (int i = 0; i < myQueue.Count; i++)
                Console.WriteLine(myQueue.ElementAt<int>(i));

            Console.WriteLine("--------End----------");
        }

        /// <summary>
        /// Illustrate stack
        /// </summary>
        private static void StackExample()
        {
            var myStack = new Stack<int>();

            //add items on the stack
            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);
            myStack.Push(4);

            //prit stack content
            for (int i = 0; i < myStack.Count; i++)
                Console.WriteLine(myStack.ElementAt<int>(i));

            //get element from stack
            int tmp = myStack.Pop();

            //print the value
            Console.WriteLine("Stack value: {0}", tmp);
        }

        /// <summary>
        /// Ilustrate dictionary
        /// </summary>
        private static void DictionaryExample()
        {
            var myDic = new Dictionary<int, string>();

            string[] names = {"Test",
                             "Testovski",
                              "Michale",
                              "Konan"};

            // add names in to the hash table. 
            //  -Key: hash code
            //  -Value: String
            for (int i = 0; i < names.Length; i++)
                myDic.Add(names[i].GetHashCode(), names[i]);

            foreach (string n in names)
                Console.WriteLine(n);
        }
        #endregion

        #region Expression evaluator with stacks
        /// <summary>
        /// 
        /// </summary>
        /// <param name="s"></param>
        private static void EvalExpression(string sExpr)
        {
            Stack<string> ops = new Stack<String>();
            Stack<double> vals = new Stack<Double>();

            string[] tokens = sExpr.Split(' ');
            foreach (string s in tokens)
            {
                if (s.Equals("("))
                    continue;
                else if (s.Equals("+"))
                    ops.Push(s);
                else if (s.Equals("-"))
                    ops.Push(s);
                else if (s.Equals("*"))
                    ops.Push(s);
                else if (s.Equals("/"))
                    ops.Push(s);
                else if (s.Equals("sqrt"))
                    ops.Push(s);

                else if (s.Equals(")"))
                { // Pop, evaluate, and push result if token is ")".
                    String op = ops.Pop();
                    double v = vals.Pop();
                    if (op.Equals("+"))
                        v = vals.Pop() + v;
                    else if (op.Equals("-"))
                        v = vals.Pop() - v;
                    else if (op.Equals("*"))
                        v = vals.Pop() * v;
                    else if (op.Equals("/"))
                        v = vals.Pop() / v;
                    else if (op.Equals("sqrt"))
                        v = Math.Sqrt(v);
                    vals.Push(v);
                } // Token not operator or paren: push double value.
                else
                    vals.Push(double.Parse(s));
                //}
                //StdOut.println(vals.pop());
            }
            Console.WriteLine("Expression value : {0}", vals.Pop());
        }
        #endregion

        #region Static Test Methods
        /// <summary>
        /// 
        /// </summary>
        private static void TestCloseParentheses()
        {
            CAppCloseParentheses parser = new CAppCloseParentheses();

            Console.WriteLine("------------------------------------------");
            parser.Expression = "1 + 2 ) * 3 - 4 ) )";
            Console.WriteLine("Original : {0} to bin : {1}", parser.Expression, parser.CloseParentheses());

            Console.WriteLine("------------------------------------------");
            parser.Expression = "1 + 2 ) * 3 - 4 ) * 5 - 6 ) ) )";
            Console.WriteLine("Original : {0} to bin : {1}", parser.Expression, parser.CloseParentheses());
            Console.WriteLine("------------------------------------------");

            parser.Expression = "1 + 2 ) * 3 - 4 ) * 22 + 13 )- 11 / 2 ) ) ) ) )"; ;
            Console.WriteLine("Original : {0} to bin : {1}", parser.Expression, parser.CloseParentheses());
            Console.WriteLine("------------------------------------------");
        }
        #endregion
        static void Main(string[] args)
        {
            //run queue example
            QueueExample();

            //run stack example
            StackExample();

            //run dictionary (hash table)
            DictionaryExample();

            string expr = "( ( 1 + 2 ) * 3 )";
            EvalExpression(expr);

            Console.WriteLine("-----------------------");
            expr = "[()]{}{[()()]()}";
            CAppParenthesesChecker checker = new CAppParenthesesChecker(expr);
            Console.WriteLine("Expression : {0} is {1}", checker.Expression, checker.CheckExpression());

            expr = "[()]{}{[()()](})";
            checker.Expression = expr;
            Console.WriteLine("Expression : {0} is {1}", checker.Expression, checker.CheckExpression());

            expr = "[(])";
            checker.Expression = expr;
            Console.WriteLine("Expression : {0} is {1}", checker.Expression, checker.CheckExpression());

            Console.WriteLine("---------------------------------");
            CAppDecToBinWithStack binConverter = new CAppDecToBinWithStack(50);
            Console.WriteLine("Dec : {0} to bin : {1}", binConverter.Number, binConverter.ToBin());

            Console.WriteLine("---------------------------------");

            TestCloseParentheses();
            Console.ReadKey();

        }

    }
}
