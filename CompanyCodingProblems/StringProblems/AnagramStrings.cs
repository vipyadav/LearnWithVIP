using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Collections;

namespace LearnWithVIP.CodingProblems.StringProblems
{
    /*
     * An anagram of a string is another string that contains same characters, 
     * only the order of characters can be different.
     * 
     * Two strings are called anagrams if they contain same set of characters but in different order.
     * 
     */

    public class AnagramStrings
    {
        // Method: 1 (Use Sorting) - Time Complexity: O(nLogn)
        public static bool AreStringsAnagramsUsingSorting(string str1, string str2)
        {
            // If length of both strings is not same, then they cannot be anagram 
            if (str1.Length != str2.Length)
            {
                return false;
            }

            char[] ch1 = str1.ToLower().ToCharArray();
            char[] ch2 = str2.ToLower().ToCharArray();

            Array.Sort(ch1);
            Array.Sort(ch2);

            string val1 = new string(ch1);
            string val2 = new string(ch2);

            return val1 == val2;
        }


        // Method: 2 (count charcters using one array) Time Complexity : O(n)
        // We can increment the value in count array for characters in str1 and decrement for characters in str2. Finally, 
        // if all count values are 0, then the two strings are anagram of each other. 
        public static bool AreStringsAnagramsUsingCountChars(string str1, string str2)
        {
            if (str1.Length != str2.Length)
                return false;

            // Create a count array and initialize all values as 0 
            int[] count = Enumerable.Repeat(0, 256).ToArray();
            int i;

            for (i = 0; i < str1.Length; i++)
            {
                count[str1[i]]++;
                count[str2[i]]--;
            }

            for (i = 0; i < 256; i++)
                if (count[i] != 0)
                    return false;
            return true;
        }

        // Method: 3 (Bit Manipulation)  Time Complexity: O(n)   Space Complexity: O(1)
        public static bool AreStringsAnagramsUsingXor(string str1, string str2)
        {
            if (string.IsNullOrWhiteSpace(str1) || string.IsNullOrWhiteSpace(str2))
                return false;

            if (str1.Length != str2.Length)
                return false;

            char[] string1CharArray = str1.ToLower().ToCharArray();
            char[] string2CharArray = str2.ToLower().ToCharArray();

            int xORValue = 0;

            for (int i = 0; i < string1CharArray.Length; i++)
            {
                xORValue ^= string1CharArray[i] ^ string2CharArray[i];
            }

            if (xORValue == 0)
                return true;

            return false;
        }
    }
}
