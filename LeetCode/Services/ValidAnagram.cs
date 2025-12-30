using System.Diagnostics;

namespace LeetCode.Services
{
    public class ValidAnagram
    {
        public bool IsAnagram(string s, string t)
        {
            char[] sArray = s.ToCharArray();
            char[] tArray = t.ToCharArray();

            List<char> sList = sArray.Order().ToList();
            List<char> tList = tArray.Order().ToList();

            return sList.SequenceEqual(tList);
        }
    }
}
