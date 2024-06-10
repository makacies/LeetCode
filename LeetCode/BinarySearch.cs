// 704.Binary Search

namespace LeetCode
{
    internal static class BinarySearch
    {
        internal static int Search(int[] nums, int target)
        {
            return RecursiveSearch(nums, target, 0);

            int RecursiveSearch(int[] nums, int target, int startIndex)
            {
                if (nums.Length == 1)
                {
                    if (nums[0] == target) return startIndex + 0;
                    return -1;
                }

                var mid = nums.Length / 2;
                if (nums[mid] == target)
                {
                    return startIndex + mid;
                }

                return nums[mid] <= target
                    ? RecursiveSearch(nums.Skip(mid).ToArray(), target, startIndex + mid)
                    : RecursiveSearch(nums.Take(mid).ToArray(), target, startIndex);
            }
        }
    }
}
