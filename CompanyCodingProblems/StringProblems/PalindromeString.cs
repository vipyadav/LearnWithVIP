using System;
using System.Collections.Generic;
using System.Text;

namespace LearnWithVIP.CodingProblems.StringProblems
{
    public static class PalindromeString
    {
        public static bool IsPalindrome(string s)
        {
            var str = s.ToLower();
            int length = str.Length;

            for (int i = 0; i < length / 2; i++)
            { 
                if (str[i] != str[length - 1 - i])
                    return false; 
            } 
            return true;
        }
    }
}
