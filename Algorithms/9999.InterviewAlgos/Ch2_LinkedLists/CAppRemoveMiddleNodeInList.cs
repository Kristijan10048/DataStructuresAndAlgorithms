using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9999.InterviewAlgos.Ch2_LinkedLists
{
    public class CAppRemoveMiddleNodeInList
    {
        private class Node
        {
            public Object Item { get; set; }
            public Node NextNode { get; set; }
        }

        private class MyList
        {
            #region Private Members
            private int m_counter = 0;
            private Node m_first;
            private Node m_last;
            #endregion

            #region Public Methods
            /// <summary>
            /// 
            /// </summary>
            public void Print()
            {
                Node currNode = m_first;

                while (currNode != null)
                {
                    Console.WriteLine("Item : {0}", currNode.Item);
                    currNode = currNode.NextNode;
                }

            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="item"></param>
            public void InsertAtEnd(Object item)
            {
                if (m_first == null)
                {
                    m_first = new Node();
                    m_first.Item = item;
                    m_first.NextNode = null;
                    m_last = m_first;
                    m_counter++;
                }
                else
                {
                    Node newNode = new Node();
                    newNode.Item = item;
                    newNode.NextNode = null;

                    m_last.NextNode = newNode;
                    m_last = m_last.NextNode;
                    m_counter++;
                }

            }

            public Node RemoveMiddleNode()
            {
                Node currNode = m_first;
                Node prevNode = m_first;
                int middle = m_counter / 2;
                int i = 0;

                while( currNode != null)
                {

                    if(i == middle - 1)
                    {
                        prevNode.NextNode = currNode.NextNode;
                        Console.WriteLine("Middle element {0}", currNode.Item);
                        return currNode ;
                    }
                    prevNode = currNode;
                    currNode = currNode.NextNode;
                    i++;
                }

                return null;
            }
            #endregion

        }

        /// <summary>
        /// 
        /// </summary>
        public static void Check()
        {
            MyList list = new MyList();

            for (int i = 0; i < 10; i++)
                list.InsertAtEnd(i);

            Console.WriteLine("---------------");
            list.Print();

            list.RemoveMiddleNode();

            Console.WriteLine("---------------");
            list.Print();
        }
    }
}
