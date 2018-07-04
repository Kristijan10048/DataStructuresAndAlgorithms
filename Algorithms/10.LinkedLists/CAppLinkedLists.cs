using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.LinkedLists
{

    public class MyList<T> : IEnumerable<T>
    {
        #region IEnumerable Implementation
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Protected Node Class
        /// <summary>
        /// 
        /// </summary>
        protected class CAppNode
        {
            public Object Item { get; set; }
            public CAppNode NextNode { get; set; }
        }
        #endregion

        #region Private Members
        private CAppNode m_firstNode = null;
        private CAppNode m_lastNode = null;

        private int m_count = 0;
        #endregion

        #region Public Methods
        /// <summary>
        /// Inserts element at given position in the list. (Zero based)
        /// </summary>
        /// <param name="position"></param>
        /// <param name="obj"></param>
        /// <returns></returns>
        public bool InsertAt(int position, Object obj)
        {
            int i = 0;
            CAppNode currNode = m_firstNode;

            while (currNode.NextNode != null)
            {
                if (i == position - 1)
                {
                    Console.WriteLine("Inserting element {0} at position :{1}", obj, position);
                    CAppNode tmpNextNode, tmpNewNode;

                    //store next node
                    tmpNextNode = currNode.NextNode;

                    //create new node
                    tmpNewNode = new CAppNode();
                    tmpNewNode.Item = obj;

                    //set next node
                    tmpNewNode.NextNode = tmpNextNode;

                    //set current next node to new node
                    currNode.NextNode = tmpNewNode;

                    m_count++;
                    break;
                }

                currNode = currNode.NextNode;
                i++;
            }

            return false;
        }

        /// <summary>
        /// Inserts element on the last position in the list
        /// </summary>
        /// <param name="o"></param>
        public virtual void InsertLast(Object obj)
        {
            //insert first element
            if (m_firstNode == null)
            {
                m_firstNode = new CAppNode();
                m_firstNode.Item = obj;
                m_firstNode.NextNode = null;
                m_lastNode = m_firstNode;

                m_count++;
            }
            else
            {
                CAppNode newNode = new CAppNode();
                newNode.Item = obj;
                m_lastNode.NextNode = newNode;
                m_lastNode = newNode;

                m_count++;
            }
        }

        /// <summary>
        /// Prints (sort of ) the content of the list
        /// </summary>
        public virtual void PrintList()
        {
            CAppNode currNode = m_firstNode;
            while (currNode != null)
            {
                Console.Write("{0}, ", currNode.Item);

                currNode = currNode.NextNode;
            }

            Console.WriteLine();
        }

        /// <summary>
        /// Removes last element of the list
        /// </summary>
        public virtual void RemoveLast()
        {
            //point to current node
            CAppNode currNode = m_firstNode;

            //loop until current_node.next points to last node 
            while (currNode.NextNode != m_lastNode)
            {
                currNode = currNode.NextNode;

                //Console.WriteLine("Curr item : {0}", currNode.Item);
            }

            //set second last (current node) to null
            currNode.NextNode = null;

            //set current node to last
            m_lastNode = currNode;

            m_count--;
        }

        /// <summary>
        /// REmoves element at given position. (Zero based inex)
        /// </summary>
        /// <param name="iPositon"></param>
        public virtual Object Remove(int iPositon)
        {
            CAppNode currNode = First, prevNode = First;
            int iCurrPos = 0;
            while (currNode != null)
            {
                //delete node at given position
                if ((iCurrPos == iPositon - 1) && (currNode.NextNode != null))
                {
                    //store the node that will be deleted
                    CAppNode tmpNode = currNode;

                    prevNode.NextNode = currNode.NextNode;
                    m_count--;
                    return tmpNode.Item;
                }

                prevNode = currNode;
                currNode = currNode.NextNode;
                iCurrPos++;
            }

            return null;
        }
        #endregion

        #region Private Properties
        /// <summary>
        /// 
        /// </summary>
        protected CAppNode First
        {
            get { return m_firstNode; }

        }

        /// <summary>
        /// 
        /// </summary>
        protected CAppNode Last
        {
            get { return m_lastNode; }
        }
        #endregion

        #region Public Properties
        /// <summary>
        /// Returns element count in the circ list
        /// </summary>
        public int Count
        {
            get { return m_count; }
        }
        #endregion
    }


    public class CircList<T> : MyList<T>
    {
        #region Private Members
        private CAppNode m_startNode;
        
        #endregion

        #region Pubic Methods  
        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        public override void InsertLast(object obj)
        {
            // set last next node to null in order to insert the element
            if (Last != null)
                Last.NextNode = null;

            base.InsertLast(obj);

            //create circ list
            if (Last != null)
                Last.NextNode = First;

            //store start node in a circ list
            m_startNode = First;
        }

        /// <summary>
        /// 
        /// </summary>
        public override void PrintList()
        {
            //print the list two circles
            CAppNode currNode = First;
            while (currNode != null)
            {
                Console.Write("{0}, ", currNode.Item);

                currNode = currNode.NextNode;

                if (currNode == m_startNode)
                {
                    Console.WriteLine("");
                    break;
                }
            }
        }
        #endregion

        #region Public Properties
        #endregion
    }


    class CAppLinkedLists
    {
        /// <summary>
        /// 
        /// </summary>
        static void SingleLinkedListTests()
        {
            MyList<int> tmpBuff = new MyList<int>();

            for (int i = 0; i < 10; i++)
            {
                tmpBuff.InsertLast(i);
            }

            Console.WriteLine("List initial state:");
            tmpBuff.PrintList();
            Console.WriteLine("------------------");

            Console.WriteLine("List state after inserting element at the end:");
            tmpBuff.InsertLast(33);
            tmpBuff.PrintList();
            Console.WriteLine("------------------");

            Console.WriteLine("List state after removing element at the end:");
            tmpBuff.RemoveLast();
            tmpBuff.PrintList();
            Console.WriteLine("------------------");

            int iElement = 44, iElPos = 3;
            Console.WriteLine("List state after inserting element {0} at the position {1}", iElement, iElPos);
            tmpBuff.InsertAt(iElPos, iElement);
            tmpBuff.PrintList();
            Console.WriteLine("------------------");

            iElPos = 3;
            Console.WriteLine("List state after removing element at the position {0}", iElPos);
            tmpBuff.Remove(iElPos);
            tmpBuff.PrintList();
            Console.WriteLine("------------------");

            iElPos = 5;
            Console.WriteLine("List state after removing element at the position {0}", iElPos);
            tmpBuff.Remove(iElPos);
            tmpBuff.PrintList();
            Console.WriteLine("------------------");
        }

        /// <summary>
        /// 
        /// </summary>
        static void CircLinkedListTests()
        {
            CircList<int> tmpBuff = new CircList<int>();

            for (int i = 0; i < 10; i++)
                tmpBuff.InsertLast(i);


            Console.WriteLine("List initial state:");
            tmpBuff.PrintList();
            Console.WriteLine("------------------");

            //Josephus problem
            Console.WriteLine("------------Josephus problem-------------");
            int m = 2;
            int n = 7;
            Console.WriteLine("M = {0}, N = {1}", m, n);

            CircList<int> jose = new CircList<int>();
            for (int i = 0; i < n; i++)
                jose.InsertLast(i);

            jose.PrintList();

            while (jose.Count > 1)
            {
                Console.WriteLine("Removes : {0}", (int)jose.Remove(m));
                jose.PrintList();
            }
        }

        static void Main(string[] args)
        {
            CircLinkedListTests();

            Console.ReadKey();
        }
    }
}
