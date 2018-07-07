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
            //Write code to remove duplicates from an unsorted linked list
            CAppDeleteDuplInLinkedList.TestIt();


            CAppPalindrome pal = new CAppPalindrome();
            string test = "1234543211";
            char[] buff = test.ToCharArray();
            Console.WriteLine("Word {0} is palindrome {1}", test, pal.Check(ref buff));

            // Assume you have a method isSubstring which checks if one word is a isSubstring of another.
            // Given two strings, s1 and s2, write code to check if s2 is a rotation of s1 using only
            // one call to isSubstring(e.g., "waterbottle" is a rotation of "erbottlewat").
            CAppIsRotationString isRot = new CAppIsRotationString();
            isRot.Check("waterbottle", "erbottlewat");
            Console.WriteLine("Is rotation check again: {0}", isRot.CheckAgain("waterbottle", "erbottlewat"));

            //Implement an algorithm to determine if a string has all unique characters. 
            //What if you cannot use additional data structures?
            CAppIsUniqueChars uniqChar = new CAppIsUniqueChars();
            string test1 = "223445";
            string test2 = "qwertyuiop[]asdfghjkl;";
            Console.WriteLine("String {0} has unique chars {1}", test1, uniqChar.Check(test1));
            Console.WriteLine("String {0} has unique chars {1}", test2, uniqChar.Check(test2));

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
