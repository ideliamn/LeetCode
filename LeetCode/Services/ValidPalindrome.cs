using System.Text.RegularExpressions;

namespace LeetCode.Services
{
    public class ValidPalindrome
    {
        public bool IsPalindrome(string s)
        {
            string removeSpecialChar = Regex.Replace(s, "[^a-zA-Z0-9]", "");
            string cleaned = removeSpecialChar.ToLowerInvariant();
            char[] split = cleaned.ToCharArray();
            List<char> reversedList = new List<char>();
            for (int i = split.Count() - 1; i >= 0; i--)
            {
                reversedList.Add(split[i]);
            }
            char[] reversed = reversedList.ToArray();
            return split.SequenceEqual(reversed);
        }
    }
}
