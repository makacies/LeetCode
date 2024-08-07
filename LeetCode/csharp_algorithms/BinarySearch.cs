// 704.Binary Search

namespace LeetCode.csharp_algorithms
{
    internal static class BinarySearch
    {
        internal static int Search(int[] nums, int target)
        {
            var startIndex = 0;
            var endIndex = nums.Length - 1;
            var mid = 0;

            while (startIndex <= endIndex)
            {
                mid = (endIndex - startIndex) / 2 + startIndex;
                if (nums[mid] == target) return mid;
                else if (nums[mid] < target)
                {
                    startIndex = mid + 1;
                }
                else
                {
                    endIndex = mid - 1;
                }
            }

            return -1;
        }
    }
}
