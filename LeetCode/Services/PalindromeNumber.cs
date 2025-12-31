namespace LeetCode.Services
{
    public class PalindromeNumber
    {
        public bool IsPalindrome(int x)
        {
            string s = x.ToString();
            char[] split = s.ToCharArray();
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
