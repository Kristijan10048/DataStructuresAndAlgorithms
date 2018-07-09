using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace _9999.InterviewAlgos.Ch1_ArraysAndStrings
{
    class CAppDeleteDuplInLinkedList
    {
        class MyList
        {
            private Node m_first;
            private Node m_last;

            private class Node
            {
                public Object Item { get; set; }
                public Node NextNode { get; set; }
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="obj"></param>
            public void InsertAtEnd(Object obj)
            {
                if (m_first == null)
                {
                    m_first = new Node();
                    m_first.Item = obj;
                    m_first.NextNode = null;
                    m_last = m_first;
                }
                else
                {
                    Node newNode = new Node();
                    newNode.Item = obj;
                    newNode.NextNode = null;

                    m_last.NextNode = newNode;
                    m_last = newNode;
                }
            }
            /// <summary>
            /// 
            /// </summary>
            public void RemoveDuplicates()
            {
                Node currNode = m_first;
                Node prevNode = m_first;
                Hashtable buffer = new Hashtable();

                while (currNode != null)
                {
                    //if item is not in the buffer add it
                    if (!buffer.Contains(currNode.Item.GetHashCode()))
                        buffer.Add(currNode.Item.GetHashCode(), currNode.Item);
                    //object is in the buffer remove the dublicate
                    else
                    {
                        prevNode.NextNode = currNode.NextNode;
                    }

                    prevNode = currNode;
                    currNode = currNode.NextNode;
                }
            }

            public void DbgPrint()
            {
                Node curNode = m_first;

                while (curNode != null)
                {
                    Console.WriteLine("List item {0}", curNode.Item);
                    curNode = curNode.NextNode;
                }

                Console.WriteLine();
            }
        }

        public static void Check()
        {
            MyList myList = new MyList();

            for (int i = 0; i < 10; i++)
            {
                myList.InsertAtEnd(i);
                myList.InsertAtEnd(i);
            }

            Console.WriteLine("Before:");
            myList.DbgPrint();

            myList.RemoveDuplicates();

            Console.WriteLine("After:");
            myList.DbgPrint();
        }
    }
}