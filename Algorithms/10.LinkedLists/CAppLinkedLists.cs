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

        #region Private Node Class
        /// <summary>
        /// 
        /// </summary>
        private class CAppNode
        {
            public Object Item { get; set; }
            public CAppNode NextNode { get; set; }
        }
        #endregion

        #region Private Members
        private CAppNode m_firstNode = null;
        private CAppNode m_lastNode = null;
        #endregion

        #region Public Methods
        /// <summary>
        /// 
        /// </summary>
        /// <param name="o"></param>
        public void Insert(Object obj)
        {
            //insert first element
            if (m_firstNode == null)
            {
                m_firstNode = new CAppNode();
                m_firstNode.Item = obj;
                m_firstNode.NextNode = null;
                m_lastNode = m_firstNode;
            }
            else
            {
                CAppNode newNode = new CAppNode();
                newNode.Item = obj;
                m_lastNode.NextNode = newNode;
                m_lastNode = newNode;
            }
        }

        /// <summary>
        /// Prints (sort of ) the content of the list
        /// </summary>
        public void PrintList()
        {
            CAppNode currNode = m_firstNode;
            while (currNode.NextNode != null)
            {
                Console.WriteLine("Item {0}", currNode.Item);

                currNode = currNode.NextNode;
            }
        }

        /// <summary>
        /// Removes last element of the list
        /// </summary>
        public void RemoveLast()
        {
            CAppNode currNode = m_firstNode;
            while (currNode.NextNode != m_lastNode)
            {
                currNode = currNode.NextNode;

                Console.WriteLine("Curr item : {0}", currNode.Item);
            }

            currNode.NextNode = null;
            m_lastNode = currNode;
        }
        #endregion
    }

    class CAppLinkedLists
    {
        static void Main(string[] args)
        {
            MyList<int> tmpBuff = new MyList<int>();

            for (int i = 0; i < 10; i++)
            {
                tmpBuff.Insert(i);
            }

            tmpBuff.PrintList();

            tmpBuff.RemoveLast();
            Console.WriteLine("------------------");
            tmpBuff.PrintList();

            tmpBuff.RemoveLast();
            Console.WriteLine("------------------");
            tmpBuff.PrintList();

            Console.ReadKey();
        }
    }
}
