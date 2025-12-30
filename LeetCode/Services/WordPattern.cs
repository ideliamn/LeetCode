using System.Diagnostics;

namespace LeetCode.Services
{
    public class WordPattern
    {
        public bool FindWordPattern(string pattern, string s)
        {
            char[] patternList = pattern.ToCharArray();
            string[] stringList = s.Split(" ");

            if (patternList.Length != stringList.Length)
            {
                return false;
            }

            Dictionary<string, string> match = new Dictionary<string, string>();
            for (int i = 0; i < patternList.Length; i++)
            {
                if (!match.ContainsKey(patternList[i].ToString()) && !match.ContainsValue(stringList[i]))
                {
                    match.Add(patternList[i].ToString(), stringList[i]);
                }
            }

            List<string> correctPattern = new List<string>();
            foreach (var p in patternList)
            {
                correctPattern.Add(match.GetValueOrDefault(p.ToString()));
            }

            for (int i = 0; i < stringList.Length; i++)
            {
                if (stringList[i] != correctPattern[i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
