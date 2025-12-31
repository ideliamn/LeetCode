using System.Diagnostics;
using System.Numerics;

namespace LeetCode.Services
{
    public class PlusOne
    {
        public int[] FindPlusOne(int[] digits)
        {
            string num = string.Empty;
            foreach (var d in digits)
            {
                num += Convert.ToString(d);
            }
            string plusOne = Convert.ToString(BigInteger.Parse(num) + 1);
            char[] plusOneChar = plusOne.ToCharArray();
            List<int> plusOneList = new List<int>();
            foreach (var p in plusOneChar)
            {
                plusOneList.Add(Convert.ToInt32(Convert.ToString(p)));
            }
            return plusOneList.ToArray();
        }
    }
}
