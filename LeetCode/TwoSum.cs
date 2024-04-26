public static class TwoSum
{
    public static int[] Calculate(int[] nums, int target)
    {
        Dictionary<int, int> nums_dict = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            var diff = target - nums[i];

            if (nums_dict.ContainsKey(diff))
            {
                return [nums_dict[diff], i];
            }

            if (!nums_dict.TryAdd(nums[i], i))
            {
                if (nums[i] * 2 == target)
                {
                    return [nums_dict[nums[i]], i];
                }
            }

        }

        return [];
    }
}