using System.Diagnostics;

namespace LeetCode.Services
{
    public class RomanToInteger
    {
        public int RomanToInt(string s)
        {
            int result = 0;

            char[] roman = s.ToCharArray();

            Dictionary<char, int> dict = new()
            {
                {'M', 1000},
                {'D', 500},
                {'C', 100},
                {'L', 50},
                {'X', 10},
                {'V', 5},
                {'I', 1}
            };

            for (int j = 0; j < roman.Length; j++)
            {
                result += dict.GetValueOrDefault(roman[j]);
                if (j > 0 && (roman[j] == 'D' || roman[j] == 'M') && roman[j - 1] == 'C')
                {
                    result -= dict.GetValueOrDefault('C') * 2;
                }
                if (j > 0 && (roman[j] == 'L' || roman[j] == 'C') && roman[j - 1] == 'X')
                {
                    result -= dict.GetValueOrDefault('X') * 2;
                }
                if (j > 0 && (roman[j] == 'V' || roman[j] == 'X') && roman[j - 1] == 'I')
                {
                    result -= dict.GetValueOrDefault('I') * 2;
                }
            }

            return result;
        }
    }
}
