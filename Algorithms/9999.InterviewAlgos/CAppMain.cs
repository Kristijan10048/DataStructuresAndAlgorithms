using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _9999.InterviewAlgos.Ch1_ArraysAndStrings;
using _9999.InterviewAlgos.Ch2_LinkedLists;
using _9999.InterviewAlgos.CompanyInterview;


namespace _9999.InterviewAlgos
{
    class CAppArraysAndStrings
    {
        static void Main(string[] args)
        {
            //Implement an algorithm to find the kth to last element of a single linked list
            //0........k,k+1,...last(n) : n-k element
            //CAppFindKthElementInLinkedList.Check();

            // Given two strings, write a method to decide if one is a permutation of the other
            //GeneratePermutations();

            // Write a method to replace all spaces in a string with '%20' You may assume that the string
            // has sufficient space at the end of the string to hold the additional characters, and that you
            // are given the "true" length of the string. (Note: if implementing in Java, please use a characters
            // array so that you can perform this operation in place)
            //CAppReplaceSpace.Check();

            //Implement an algorithm to delete a node in the middle of a singly linked list, 
            //give only access to that node
            //CAppRemoveMiddleNodeInList.Check();


            //CAppCircList.Check();


            //Implement a function to check if a linked list is a palindrome
            //don't forget import statements!
            //1234321
            CAppIsLinkedListPalindrome.Check();

            //Given a non-negative integer num,   add all its digits until the result has only one digit.

            //For example:
            //Given num = 38, the process is like: 3 + 8 = 11, 1 + 1 = 2. Since 2 has only one digit, return it.

            //Follow up:
            //Could you do it without any loop/recursion in O(1) runtime?
            CAppSumOfDigits.Check();

            //Given an array of size n, find the majority element. 
            //The majority element is the element that appears more than ⌊ n/2 ⌋ times.
            //You may assume that the array is non-empty and the majority element always exist in the array.
            CAppMajorityElement.Check();

            // You are given two non-empty linked lists representing two non-negative integers. The digits are stored in reverse order and each of their nodes contain a single digit. 
            // Add the two numbers and return it as a linked list.
            // You may assume the two numbers do not contain any leading zero, except the number 0 itself.
            // Input: (2 -> 4 -> 3) + (5 -> 6 -> 4)
            // Output: 7 -> 0 -> 8
            ///CAppSumOfTwoLists.Check();
            
            //prints all prime numbers for 1 to 1000
            CAppPrimeNumbers.PrimeNumbers();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        /// <summary>
        /// Write code to remove duplicates from an unsorted linked list
        /// </summary>
        private static void RemoveDuplFromLinkedList()
        {
            //Write code to remove duplicates from an unsorted linked list
            CAppDeleteDuplInLinkedList.Check();
        }

        /// <summary>
        /// Checks if a word is a palindrome or not
        /// </summary>
        private static void IsPalindrome()
        {
            CAppPalindrome pal = new CAppPalindrome();
            string test = "1234543211";
            char[] buff = test.ToCharArray();
            Console.WriteLine("Word {0} is palindrome {1}", test, pal.Check(ref buff));
        }

        /// <summary>
        ///  Assume you have a method isSubstring which checks if one word is a isSubstring of another.
        /// Given two strings, s1 and s2, write code to check if s2 is a rotation of s1 using only
        /// one call to isSubstring(e.g., "waterbottle" is a rotation of "erbottlewat").
        /// </summary>
        private static void IsRotation()
        {
            CAppIsRotationString isRot = new CAppIsRotationString();
            isRot.Check("waterbottle", "erbottlewat");
            Console.WriteLine("Is rotation check again: {0}", isRot.CheckAgain("waterbottle", "erbottlewat"));
        }

        /// <summary>
        ///Implement an algorithm to determine if a string has all unique characters. 
        ///What if you cannot use additional data structures?
        /// </summary>
        private static void UniqueChars()
        {
            CAppIsUniqueChars uniqChar = new CAppIsUniqueChars();
            string test1 = "223445";
            string test2 = "qwertyuiop[]asdfghjkl;";
            Console.WriteLine("String {0} has unique chars {1}", test1, uniqChar.Check(test1));
            Console.WriteLine("String {0} has unique chars {1}", test2, uniqChar.Check(test2));
        }

        /// <summary>
        /// 
        /// </summary>
        private static void GeneratePermutations()
        {
            //CAppPermutationGenerator.Check();
            //CAppPermutationGenerator.CheckPermutationsMk1BruteForce("abc", "bca");
            //CAppPermutationGenerator.CheckPermutationsMk1BruteForce("abc", "aaa");
            CAppPermutationGenerator.CheckPermutationsMk2("1234567890", "0234567891");
            CAppPermutationGenerator.CheckPermutationsMk2("123456789a", "023456789a");
        }
    }


}
