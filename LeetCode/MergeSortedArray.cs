// 88. Merge Sorted Array

namespace LeetCode
{
    internal static class MergeSortedArray
    {
        public static void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            var subNums1 = nums1[..m];
            var cursor1 = 0;
            var cursor2 = 0;

            for (int i = 0; i < nums1.Length; i++)
            {
                if (cursor1 == m)
                {
                    nums1[i] = nums2[cursor2];
                    cursor2++;
                }
                else if (cursor2 == n)
                {
                    nums1[i] = subNums1[cursor1];
                    cursor1++;
                }
                else if (nums2[cursor2] <= subNums1[cursor1])
                {
                    nums1[i] = nums2[cursor2];
                    cursor2++;
                }
                else if (subNums1[cursor1] <= nums2[cursor2])
                {
                    nums1[i] = subNums1[cursor1];
                    cursor1++;
                }
            }
        }
    }
}
