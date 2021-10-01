using System.Linq;

namespace LearnWithVIP.CodingProblems.StringProblems
{
    public static class ReverseString
    {
        public static string Reverse1(string str)
        {
            var result = new char[str.Length];
            var i = str.Length - 1;
            foreach (char c in str)
                result[i--] = c;
            return new string(result);
        }

        public static string Reverse2(string x)
        {
            string result = "";
            for (int i = x.Length - 1; i >= 0; i--)
                result += x[i];
            return result;
        }

        public static string Reverse(string str)
        {
            if ((str == null) || (str.Length <= 1))
                return str;
            return str.Last() + Reverse(str.Substring(0, str.Length - 1));
            // str.Last() => str[str.Length-1]
        }
    }
}
