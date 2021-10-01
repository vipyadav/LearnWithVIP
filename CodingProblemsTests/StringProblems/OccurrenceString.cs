using System;
using System.Collections.Generic;
using System.Text;

namespace LearnWithVIP.CodingProblems.StringProblems
{
    public static class OccurrenceString
    {
        public static char MostOccurringCharInString(string str)
        {
            int mostOccurrence = -1;
            char mostOccurringChar = ' ';

            foreach (char currentChar in str)
            {
                int foundCharOccreence = 0;
                foreach (char charToBeMatch in str)
                {
                    if (currentChar == charToBeMatch)
                        foundCharOccreence++;
                }
                if (mostOccurrence < foundCharOccreence)
                {
                    mostOccurrence = foundCharOccreence;
                    mostOccurringChar = currentChar;
                }
            }
            return mostOccurringChar;
        }

        public static char MaxOccuringChar(string str)
        {
            // Create array to keep the count of individual characters and initialize the array as 0 
            int[] count = new int[256];

            // Construct character count array from the input string. 
            int len = str.Length;
            for (int i = 0; i < len; i++)
                count[str[i]]++;

            int max = -1; // Initialize max count 
            char result = ' '; // Initialize result 

            // Traversing through the string and  
            // maintaining the count of each character 
            for (int i = 0; i < len; i++)
            {
                if (max < count[str[i]])
                {
                    max = count[str[i]];
                    result = str[i];
                }
            }

            return result;
        }

        /* Determine if a string has all Unique Characters */
        public static bool UniqueCharacters(string str)
        {
            char[] chArray = str.ToCharArray();

            Array.Sort(chArray);

            for (int i = 0; i < chArray.Length - 1; i++)
            {
                // if at any time, 2 adjacent elements become equal, return false
                if (chArray[i] == chArray[i + 1])
                    return false;
            }

            return true;
        }
    }
}
