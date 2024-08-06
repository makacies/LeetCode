// 217. Contains Duplicate

namespace LeetCode
{
    internal class ContainsDuplicate
    {
        internal bool Contains(int[] nums)
        {
            Array.Sort(nums);
            var previous = nums[0] - 1;
            foreach (int i in nums)
            {
                if (i == previous) return true;
                else previous = i;
            }

            return false;
        }
    }
}
