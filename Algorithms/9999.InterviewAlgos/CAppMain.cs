using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _9999.InterviewAlgos.Ch1_ArraysAndStrings;

namespace _9999.InterviewAlgos
{
    class CAppArraysAndStrings
    {
        static void Main(string[] args)
        {
            //Implement an algorithm to find the kth to last element of a single linked list
            //0........k,k+1,...last(n) : n-k element
            CAppFindKthElementInLinkedList.Check();

            // Given two strings, write a method to decide if one is a permutation of the other
            GeneratePermutations();


            // Write a method to replace all spaces in a string with '%20' You may assume that the string
            // has sufficient space at the end of the string to hold the additional characters, and that you
            // are given the "true" length of the string. (Note: if implementing in Java, please use a characters
            // array so that you can perform this operation in place)
            CAppReplaceSpace.Check();

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
        ///   Implement an algorithm to determine if a string has all unique characters. 
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
