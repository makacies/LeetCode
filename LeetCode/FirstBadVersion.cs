// 278. First Bad Version

namespace LeetCode
{
    internal static class FirstBadVersion 
    {
        public static int Find(int n)
        {
            var start = 0;
            var end = n;

            while (start < end)
            {
                var mid = (end - start) / 2 + start;

                if (IsBadVersion(mid))
                {
                    end = mid;
                }
                else
                {
                    start = mid + 1;
                }
            }

            return start;
        }

        static bool IsBadVersion(int version)
        {
            return version >= 4;
        }
    }
}
