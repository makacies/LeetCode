// 53. Maximum Subarray

namespace LeetCode
{
    internal static class MaximumSubarray
    {
        public static int MaxSubArray(int[] nums)
        {
            var max = nums[0];
            var sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                if (nums[i] > sum)
                {
                    sum = nums[i];
                }
                if (sum > max)
                {
                    max = sum;
                }
            }
            return max;
        }
    }
}
