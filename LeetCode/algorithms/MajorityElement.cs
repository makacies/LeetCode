// 169. Majority Element

namespace LeetCode.csharp_algorithms
{
    internal static class MajorityElement
    {
        public static int GetMajorityElement(int[] nums)
        {
            // First pass: find a potential candidate for the majority element
            int candidate = nums[0];
            int count = 1;

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] == candidate)
                {
                    count++;
                }
                else
                {
                    count--;
                    if (count == 0)
                    {
                        candidate = nums[i];
                        count = 1;
                    }
                }
            }

            // Second pass: verify the candidate
            count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == candidate)
                {
                    count++;
                }
            }

            if (count > nums.Length / 2)
            {
                return candidate;
            }
            else
            {
                throw new InvalidOperationException("No majority element found");
            }
        }
    }
}
