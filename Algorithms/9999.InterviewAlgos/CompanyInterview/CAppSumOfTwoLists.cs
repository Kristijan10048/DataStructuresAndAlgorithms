using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9999.InterviewAlgos.CompanyInterview
{

    class Node
    {
        public Object Item { get; set; }
        public Node NextNode { get; set; }
    }

    class MyList
    {
        private Node m_first;
        private Node m_last;
        private int m_iCount;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        public void InsertAtEnd(Object item)
        {
            if (m_first == null)
            {
                Node newNode = new Node();
                newNode.Item = item;
                newNode.NextNode = null;

                m_first = newNode;
                m_last = m_first;
            }
            else
            {
                Node newNode = new Node();
                newNode.Item = item;
                newNode.NextNode = null;
                m_last.NextNode = newNode;
                m_last = m_last.NextNode;
            }
        }

        public void InsertAtBegining(Object item)
        {
            if (m_first == null)
            {
                m_first = new Node();
                m_first.Item = item;
                m_first.NextNode = null;
                m_last = m_first;
            }
            else
            {
                Node newNode = new Node();
                newNode.Item = item;
                newNode.NextNode = m_first;
                m_first = newNode;
            }
        }

        public Node First
        {
            get { return m_first; }
        }

        public Node Last
        {
            get { return m_last; }
        }

        public void Print()
        {
            Node currNode = First;

            while (currNode != null)
            {
                Console.Write("{0}", currNode.Item);
                currNode = currNode.NextNode;
            }
            Console.WriteLine();
        }
    }

    class CAppSumOfTwoLists
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="arg1"></param>
        /// <param name="arg2"></param>
        public static MyList SumOfList(MyList arg1, MyList arg2)
        {
            Node currNode1 = arg1.First;
            Node currNode2 = arg2.First;
            MyList oSum = new MyList();
            int remaining = 0;

            while (currNode1 != null && currNode2 != null)
            {
                int opp1 = (int)currNode1.Item;
                int opp2 = (int)currNode2.Item;
                int iSum = opp1 + opp2;

                //calculate remaining
                if (iSum >= 10)
                {
                    remaining = 1;
                    iSum += -10;
                    oSum.InsertAtEnd(iSum);
                }
                else
                {
                    oSum.InsertAtEnd(iSum + remaining);
                    remaining = 0;
                }

                currNode1 = currNode1.NextNode;
                currNode2 = currNode2.NextNode;
            }

            return oSum;
        }

        public static MyList SumOfListMk1(MyList arg1, MyList arg2)
        {
            Node currNode1 = arg1.First;
            Node currNode2 = arg2.First;
            MyList oSum = new MyList();

            Stack<object> stackArg1 = new Stack<object>();
            Stack<object> stackArg2 = new Stack<object>();
            while (currNode1 != null && currNode2 != null)
            {
                if (currNode1 != null)
                    stackArg1.Push(currNode1.Item);

                if (currNode2 != null)
                    stackArg2.Push(currNode2.Item);

                currNode1 = currNode1.NextNode;
                currNode2 = currNode2.NextNode;
            }

            int remaining = 0;
            int opp1 = 0;
            int opp2 = 0;
            int iSum = 0;
            while (stackArg1.Count > 0 || stackArg2.Count > 0)
            {
                opp1 = (int)stackArg1.Pop();
                opp2 = (int)stackArg2.Pop();

                //opp1 = char.Parse();
                //opp2 = char.Parse(stackArg2.Pop().ToString());

                iSum = opp1 + opp2;

                if (iSum + remaining > 10)
                {
                    iSum = iSum - 10 + remaining;
                    remaining = 1;
                    oSum.InsertAtBegining(iSum);
                    iSum = 0;
                }
                else
                {
                    iSum = iSum + remaining;
                    oSum.InsertAtBegining(iSum);
                    remaining = 0;
                    iSum = 0;
                }
            }

            if (remaining == 1)
                oSum.InsertAtBegining(remaining);

            return oSum;
        }

        public static void Check()
        {
            MyList arg1 = new MyList();
            MyList arg2 = new MyList();

            arg1.InsertAtEnd(9); arg1.InsertAtEnd(9); arg1.InsertAtEnd(1);
            arg2.InsertAtEnd(9); arg2.InsertAtEnd(9); arg2.InsertAtEnd(3);

            Console.WriteLine("Argument 1:");
            arg1.Print();

            Console.WriteLine("Argument 2:");
            arg2.Print();


            MyList oSum = SumOfListMk1(arg1, arg2);

            Console.WriteLine("Sum :");
            oSum.Print();
        }
    }
}