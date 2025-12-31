namespace LeetCode.Services
{
    public class SingleNumber
    {
        public int FindSingleNumber(int[] nums)
        {
            Dictionary<int, int> concurrency = new Dictionary<int, int>();

            foreach (var n in nums)
            {
                if (!concurrency.ContainsKey(n))
                {
                    concurrency.Add(n, 1);
                }
                else
                {
                    concurrency[n] = concurrency.GetValueOrDefault(n) + 1;
                }
            }

            return concurrency.First(c => c.Value == 1).Key;
        }
    }
}
