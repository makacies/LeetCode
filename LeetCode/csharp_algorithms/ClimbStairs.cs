// 70. Climbing Stairs

namespace LeetCode.csharp_algorithms
{
    public static class ClimbStairs
    {
        public static int PossibleWays(int n)
        {
            var prev = 0;
            var current = 1;

            for (int i = 1; i <= n; i++)
            {
                var temp = prev;
                prev = current;
                current += temp;
            }

            return current;
        }
    }
}
