using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9999.InterviewAlgos.Ch2_LinkedLists
{
    class CAppCircList
    {
        #region Private Members
        private int m_counter = 0;
        private Node m_last;
        #endregion

        class Node
        {
            public Object Item { get; set; }
            public Node NextNode { get; set; }
        }

        /// <summary>
        /// Inserts element before last element. Last pointer does not chnage
        /// </summary>
        /// <param name="item"></param>
        public void InsertAtBegining(Object item)
        {
            if (m_last == null)
            {
                Node newNode = new Node();
                newNode.Item = item;

                //add loop back
                newNode.NextNode = newNode;

                //set last to the new node
                m_last = newNode;
                m_counter++;
            }
            else
            {
                Node newNode = new Node();
                newNode.Item = item;

                //m_last.NextNode is first node
                newNode.NextNode = m_last.NextNode;

                //point last next node to new node
                m_last.NextNode = newNode;
            }
        }

        public void InsertAtEnd(Object item)
        {
            if (m_last == null)
            {
                Node newNode = new Node();
                newNode.Item = item;

                //create loop back
                newNode.NextNode = newNode;

                //set last node to new node
                m_last = newNode;
            }
            else
            {
                Node newNode = new Node();

                newNode.Item = item;

                newNode.NextNode = m_last.NextNode;

                m_last.NextNode = newNode;

                m_last = newNode;
            }
        }

        public void Print()
        {
            //first node
            Node currNode = m_last.NextNode;

            Console.WriteLine("Circ List items");
            do
            {
                Console.Write("{0} --> ", currNode.Item);
                currNode = currNode.NextNode;
            }
            while (currNode != m_last.NextNode);
        }

        public static void Check()
        {
            CAppCircList circList = new CAppCircList();

            for (int i = 0; i < 5; i++)
            {
                circList.InsertAtBegining(i);
            }

            Console.WriteLine("Circ list content :");

            circList.InsertAtEnd(99);
            circList.InsertAtBegining(100);

            Console.WriteLine("Circ list content :");
            circList.Print();
        }
    }
}
