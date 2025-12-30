namespace LeetCode.Services
{
    public class ReverseWordInAString
    {
        public string ReverseWords(string s)
        {
            string result = "";

            string[] split = s.Split(" ");
            List<string> words = new List<string>();
            foreach (var sp in split)
            {
                if (sp != "")
                {
                    words.Add(sp);
                }
            }

            for (int i = words.Count - 1; i >= 0; i--)
            {
                result += words[i];
                if (i != 0)
                {
                    result += " ";
                }
            }

            return result;
        }
    }
}
