// 338. Counting Bits

namespace LeetCode.algorithms
{
    internal static class CountingBits
    {
        public static int[] CountBits(int n)
        {
            var ans = new int[n + 1];
            for (int i = 0; i < ans.Length; i++)
            {
                ans[i] = ans[i >> 1] + (i & 1);
            }

            return ans;
        }
    }
}
