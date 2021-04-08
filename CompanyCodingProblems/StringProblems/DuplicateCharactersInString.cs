using System.Collections.Generic;
using System.Linq;

namespace LearnWithVIP.CodingProblems.StringProblems
{
    // How to remove duplicate characters from string.
    /*
                Input: vipinyadav
                Output: vipnyad
    */

    public static class DuplicateCharactersInString
    {

        public static string RemoveDuplicateChars(string str)
        {
            string result = "";

            // Loop over each character.
            foreach (var ch in str.Where(ch => result.IndexOf(ch) == -1))
            {
                result += ch;
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
