using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LearnWithVIP.CodingProblems.StringProblems
{
    // How to remove duplicate characters from string.
    /*
                Input: vipinyadav
                Output: vipnyad
    */

    public class DuplicateCharactersInString
    {

        public static string RemoveDuplicateChars(string str)
        {
            // --- Removes duplicate chars using string concats. ---
            // Store encountered letters in this string.
            string table = "";

            // Store the result in this string.
            string result = "";

            // Loop over each character.
            foreach (char ch in str)
            {
                // See if character is in the table.
                if (table.IndexOf(ch) == -1)
                {
                    // Append to the table and the result.
                    table += ch;
                    result += ch;
                }
            }
            return result;
        }

        public static string RemoveDuplicateCharsByLinq(string str)
        {
            return new string(str.ToCharArray().Distinct().ToArray());
        }

        // Use HashSet to map the string to char. 
        // This will remove the duplicate characters from a string.
        public static string RemoveDuplicateCharsByHashset(string str)
        {
            var unique = new HashSet<char>(str);
            return new string(unique.ToArray());
        }
    }
}
