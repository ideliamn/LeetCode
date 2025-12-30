namespace LeetCode.Services
{
    public class RotateArray
    {
        public void Rotate(int[] nums, int k)
        {
            int length = nums.Length;
            k = k % length;
            // 1,2,3,4,5,6,7
            // k = 3
            // length 7
            // start from 5. index 5
            // 7-3+1
            // length-k+1
            int start = length - k;
            List<int> newNum = new List<int>();
            for (int i = start; i < length; i++)
            {
                newNum.Add(nums[i]);
            }
            for (int i = 0; i < start; i++)
            {
                newNum.Add(nums[i]);
            }
            for (int i = 0; i < length; i++)
            {
                nums[i] = newNum[i];
            }
        }
    }
}
