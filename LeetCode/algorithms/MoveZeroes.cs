// 283. Move Zeroes

namespace LeetCode.algorithms
{
    internal class MoveZeroes
    {
        public void Move(int[] nums)
        {
            if (nums.Length == 1) return;
            var indices = new Queue<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0) indices.Enqueue(i);
                else
                {
                    if (indices.Count > 0)
                    {
                        var zeroIndex = indices.Dequeue();
                        nums[zeroIndex] = nums[i];
                        nums[i] = 0;
                        indices.Enqueue(i);
                    }
                }
            }
        }
    }
}
