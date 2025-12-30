using Microsoft.Extensions.FileSystemGlobbing.Internal;
using System.Diagnostics;

namespace LeetCode.Services
{
    public class IsIsomorphic
    {
        public bool FindIsIsomorphic(string s, string t)
        {
            if (s.Length != t.Length)
            {
                return false;
            }

            char[] sList = s.ToCharArray();
            char[] tList = t.ToCharArray();

            Dictionary<string, string> match = new Dictionary<string, string>();
            for (int i = 0; i < s.Length; i++)
            {
                if (!match.ContainsKey(s[i].ToString()) && !match.ContainsValue(t[i].ToString()))
                {
                    match.Add(s[i].ToString(), t[i].ToString());
                }
            }

            string checkS = string.Empty;
            string checkT = string.Empty;
            for (int i = 0; i < s.Length; i++)
            {
                checkT += match.GetValueOrDefault(s[i].ToString());
                checkS += match.FirstOrDefault(m => m.Value == t[i].ToString()).Key;
            }

            return s.Equals(checkS) && t.Equals(checkT);
        }
    }
}
