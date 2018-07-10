using System;
using System.Collections.Generic;
using System.Linq;


namespace _9999.InterviewAlgos.Ch2_LinkedLists
{
    class CAppIsLinkedListPalindrome
    {
        //TODO Use my list
        private class Node
        {
            public Object Item { get; set; }
            public Node NextNode { get; set; }
        }

        class MyList
        {
            private Node m_first;
            private Node m_last;

            public void InsertAtEnd(Object item)
            {
                if (m_first == null)
                {
                    Node newNode = new Node();

                }
            }
        }

        public static bool IsPalindrome(string sArg)
        {
            List<Object> buffer = new List<object>();
            int i = 0;

            //add characters to list
            for (i = 0; i < sArg.Length; i++)
            {
                buffer.Add(sArg[i]);
            }

            bool isOdd = (buffer.Count % 2) == 1;
            Stack<Object> stackBuff = new Stack<object>();

            //push first half of the list in the stack
            i = 0;
            while (i < buffer.Count / 2)
            {
                stackBuff.Push(buffer.ElementAt(i)); 
                i++;
            }

            for (i = buffer.Count / 2 + 1; i < buffer.Count; i++)
            {
                //skip middle element if length is odd
                if (isOdd)
                {
                    i++;
                    continue;
                }

                //get top element on the stack
                char currChar = (char)stackBuff.Pop();

                //if top element from the stack and second half of the list dont match return false
                if (currChar != (char)buffer[i])
                {
                    return false;
                }
            }

            return true;
        }

        public static void Check()
        {
            string pal = "12343121";

            Console.WriteLine("Word {0} in a list is a palindrome: {1}", pal, IsPalindrome(pal));
        }
    }
}
