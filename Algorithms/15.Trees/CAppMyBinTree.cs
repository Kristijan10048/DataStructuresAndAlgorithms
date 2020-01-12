using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Trees
{
    class Node
    {
        public Node LeftNode { get; set; }
        public Node RightNode { get; set; }
        public IComparable Item { get; set; }


        public string DisplayNode()
        {
            StringBuilder output = new StringBuilder();
            displayNode(output, 0);
            return output.ToString();
        }

        private void displayNode(StringBuilder output, int depth)
        {
            if (RightNode != null)
                RightNode.displayNode(output, depth + 1);

            output.Append('\t', depth);
            output.AppendLine(Item.ToString());


            if (LeftNode != null)
                LeftNode.displayNode(output, depth + 1);

        }
    }

    /// <summary>
    /// Algorithm Inorder(tree) [left node], [root], [right node]
    ///1. Traverse the left subtree, i.e., call Inorder(left-subtree)
    ///2. Visit the root.
    ///3. Traverse the right subtree, i.e., call Inorder(right-subtree)   
    ///Peorder: [root] [left node] [right node] 
    ///Postorder [left node] [right node] [root]
    ///</summary>
    class CAppMyBinTree
    {
        private Node m_root;

        #region Private Methods
        /// <summary>
        /// Inserts element in to a binary search tree
        /// </summary>
        /// <param name="item"></param>
        /// <param name="parent"></param>
        private void Insert(IComparable item, Node parent)
        {
            int cmp = item.CompareTo(parent.Item);
            if (cmp <= 0 && parent.LeftNode == null)
            {
                Node newNode = new Node();
                newNode.LeftNode = null;
                newNode.RightNode = null;
                newNode.Item = item;

                parent.LeftNode = newNode;
                return;
            }
            else if (cmp > 0 && parent.RightNode == null)
            {
                Node newNode = new Node();
                newNode.LeftNode = null;
                newNode.RightNode = null;
                newNode.Item = item;

                parent.RightNode = newNode;
                return;
            }
            else if (cmp <= 0 && parent.LeftNode != null)
            {
                Insert(item, parent.LeftNode);
            }
            else if (cmp > 0 && parent.RightNode != null)
            {
                Insert(item, parent.RightNode);
            }

        }

        /// <summary>
        /// Finds element in to a binary search tree
        /// </summary>
        /// <param name="item"></param>
        /// <param name="parent"></param>
        /// <param name="result"></param>
        /// <returns></returns>
        private bool Find(IComparable item, Node parent, out Node result)
        {
            result = null;
            if (parent == null)
                return false;

            int cmp = item.CompareTo(parent.Item);

            if (cmp == 0)
            {
                result = parent;
                return true;
            }
            else if (cmp <= 0)
                return Find(item, parent.LeftNode, out result);
            else if (cmp > 0)
                return Find(item, parent.RightNode, out result);

            return false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="root"></param>
        /// <param name="minValue"></param>
        /// <param name="maxValue"></param>
        /// <returns></returns>
        private bool CheckIfBST(Node root, IComparable minValue, IComparable maxValue)
        {
            if (root == null)
                return true;
            if (root.Item.CompareTo(minValue) > 0 &&
                root.Item.CompareTo(maxValue) <= 0 &&
                CheckIfBST(root.LeftNode, minValue, root.Item) &&
                CheckIfBST(root.RightNode, root.Item, maxValue))
                return true;
            else
                return false;
        }

        /// <summary>
        /// Finds minimum element recursively in BST
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        private IComparable FindMin(Node root)
        {

            Node currNode = root;

            //not found
            if (currNode == null)
                return -1;
            //we are at the bottom node
            else if (currNode.LeftNode == null)
                return currNode.Item;
            else
                return FindMin(currNode.LeftNode);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="parent"></param>
        /// <param name="item"></param>
        /// <param name="level"></param>
        private void InsertRec(Node parent, int item, int level)
        {
            if (level <= 0)
                return;



            parent.LeftNode = new Node();
            parent.LeftNode.Item = (int)parent.Item * 2;

            parent.RightNode = new Node();
            parent.RightNode.Item = (int)parent.Item * 2 + 1;

            level--;

            InsertRec(parent.LeftNode, item, level);
            InsertRec(parent.RightNode, item, level);
        }
        #endregion

        #region Public Methods
        /// <summary>
        /// 
        /// </summary>
        public void CreateDummyTree()
        {
            m_root = null;
            m_root = new Node();
            m_root.Item = 1;
            InsertRec(m_root, 1, 3);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        public void Insert(IComparable item)
        {
            if (m_root == null)
            {
                m_root = new Node();
                m_root.LeftNode = null;
                m_root.RightNode = null;
                m_root.Item = item;
            }
            else
            {
                Insert(item, m_root);
            }
        }

        /// <summary>
        /// Prints a tree. Pre Oder. Root first left node, right node
        /// </summary>
        /// <param name="parent"></param>
        /// <param name="level"></param>
        public void Print(Node parent, int level, string sMsg)
        {
            if (parent == null)
                return;

            Console.WriteLine("{2} level {0}, Item:{1}", level, parent.Item, sMsg);

            Print(parent.LeftNode, level + 1, "Left node");
            Print(parent.RightNode, level + 1, "Right node");
        }

        /// <summary>
        /// Finds element in to a binary search tree
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool Find(IComparable item)
        {
            Node res;
            return Find(item, m_root, out res);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IComparable FindMin()
        {
            return FindMin(m_root);
        }

        /// <summary>
        /// Checks if a tree is a binary search tree
        /// </summary>
        /// <returns></returns>
        public bool CheckIfBST()
        {
            return CheckIfBST(m_root, Int32.MinValue, Int32.MaxValue);
        }
        #endregion

        /// <summary>
        /// 
        /// </summary>
        public void Print()
        {
            string indent = "\t";

            for (int i = 0; i < 10; i++) ;
            indent += indent;

            Print(m_root, 0, "Root");
        }

        /// <summary>
        /// 
        /// </summary>
        public static void Check()
        {
            CAppMyBinTree tmpTree = new CAppMyBinTree();

            tmpTree.Insert(-20);
            for (int i = 0; i < 20; i++)
            {
                tmpTree.Insert(i);
                tmpTree.Insert(i + 1);
                tmpTree.Insert(i + 2);
            }

            Console.WriteLine("Content of bin tree");
            tmpTree.Print();

            int t = 20;
            Console.WriteLine("Item {0} in the three: {1}", t, tmpTree.Find(t));

            t = -20;
            Console.WriteLine("Item {0} in the three: {1}", t, tmpTree.Find(t));
            Console.WriteLine("BST : {0}", tmpTree.CheckIfBST());
            Console.WriteLine("Minimum element: {0}", tmpTree.FindMin());
            Console.WriteLine("-----------------------------------------");
            tmpTree.CreateDummyTree();
            Console.WriteLine("Content of bin tree");
            tmpTree.Print();

            Console.WriteLine("-----------------------------------------");
            CAppMyBinTree tmp1 = new CAppMyBinTree();
            //tmp1.Insert(10);
            //tmp1.Insert(9);
            //tmp1.Insert(11);
            //tmp1.Insert(1);
            //tmp1.Insert(50);
            //tmp1.Insert(12);
            //tmp1.Insert(15);
            tmp1.InsertRec(tmp1.m_root, 1, 3);
            Console.WriteLine(tmp1.m_root.DisplayNode());

        }
    }
}
