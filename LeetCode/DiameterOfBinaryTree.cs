// 543.Diameter of Binary Tree

namespace LeetCode
{
    internal class DiameterOfBinaryTree
    {
        public int Get(TreeNode root)
        {
            if (root == null) return 0;
            
            var left = Get(root.left);
            var leftPath = GetLongestPath(root.left);
            var right = Get(root.right);
            var rightPath = GetLongestPath(root.right);

            return Math.Max(left, Math.Max(right, leftPath + rightPath));
        }

        int GetLongestPath(TreeNode root)
        {
            if (root == null) return 0;

            var left = GetLongestPath(root.left);
            var right = GetLongestPath(root.right);

            return left >= right ? ++left : ++right;
        }
    }
}
