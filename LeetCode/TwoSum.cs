namespace LeetCode
{
    public static class TwoSum
    {
        public static int[] Calculate(int[] nums, int target)
        {
            Dictionary<int, int> numsDict = [];

            for (int i = 0; i < nums.Length; i++)
            {
                var diff = target - nums[i];

                if (numsDict.ContainsKey(diff))
                {
                    return [numsDict[diff], i];
                }

                if (!numsDict.TryAdd(nums[i], i))
                {
                    if (nums[i] * 2 == target)
                    {
                        return [numsDict[nums[i]], i];
                    }
                }

            }

            return [];
        }
    }
}