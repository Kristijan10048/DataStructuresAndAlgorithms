using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9999.InterviewAlgos.Ch1_ArraysAndStrings
{
    class CAppFindKthElementInLinkedList
    {
        private class Node
        {
            public Object Item { get; set; }
            public Node NextNode { get; set; }
        }

        public class MyLinkedList
        {
            private Node m_first = null;
            private Node m_last = null;
            private int m_count = 0;

            /// <summary>
            /// 
            /// </summary>
            /// <param name="element"></param>
            public void InsertAtEnd(Object element)
            {
                if (m_first == null)
                {
                    m_first = new Node();
                    m_first.Item = element;
                    m_last = m_first;
                    m_count++;
                }
                else
                {
                    Node newNode = new Node();
                    newNode.Item = element;
                    newNode.NextNode = null;
                    m_last.NextNode = newNode;
                    m_last = m_last.NextNode;

                    m_count++;
                }
            }

            /// <summary>
            /// Authors method
            /// </summary>
            /// <param name="k"></param>
            /// <returns></returns>
            public Object KthToLast(int k)
            {
                if (k < 0)
                    return null;

                if (m_first == null)
                    return null;

                Node currNode = m_first;

                int i = 0;
                while (i != k)
                {
                    currNode = currNode.NextNode;

                    if (currNode == null)
                        return null;

                    i++;
                }

                Node p2 = currNode;
                Node p1 = m_first;

                while (p2 != null)
                {
                    p1 = p1.NextNode;
                    p2 = p2.NextNode;
                }
                if (p1 != null)
                    return p1.Item;
                else
                    return null;

            }
            
            /// <summary>
            /// 
            /// </summary>
            /// <param name="k"></param>
            /// <returns></returns>
            public Object MyKthToLast(int k)
            {
                if (k < 0)
                    return null;

                int offset = m_count - k;
                int i = 0;
                Node currNode = m_first;

                while (i < offset)
                {
                    if (currNode == null)
                        return null;

                    i++;
                    currNode = currNode.NextNode;
                }

                return currNode.Item;
            }

            /// <summary>
            /// 
            /// </summary>
            public void PrintList()
            {
                Node currNode = m_first;
                int iPos = 0;
                while (currNode != null)
                {
                    Console.WriteLine("{0} element: {1}", iPos, currNode.Item);
                    currNode = currNode.NextNode;
                    iPos++;
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public static void Check()
        {
            MyLinkedList myBuff = new MyLinkedList();
            for (int i = 0; i < 15; i++)
            {
                myBuff.InsertAtEnd(i);
            }

            myBuff.PrintList();
            int k = 1;
            Console.WriteLine("{0}th element from end is {1}", k, myBuff.KthToLast(k));

            Console.WriteLine("{0}th element from end is {1} (With count)", k, myBuff.MyKthToLast(k));
        }
    }
}
