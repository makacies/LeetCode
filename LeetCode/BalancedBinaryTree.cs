// 110. Balanced Binary Tree

namespace LeetCode
{
    internal static class BalancedBinaryTree
    {
        internal static bool IsBalanced(TreeNode root)
        {
            if (root == null) return true;
            var heightLeft = FindHeight(root.left);
            var heightRight = FindHeight(root.right);

            if (Math.Abs(heightLeft - heightRight) > 1) return false;
            return IsBalanced(root.left) && IsBalanced(root.right);

            int FindHeight(TreeNode root)
            {
                if (root == null) return 0;

                var heightLeft = FindHeight(root.left);
                var heightRight = FindHeight(root.right);

                return heightLeft > heightRight ? heightLeft + 1 : heightRight + 1;
            }
        }
    }
}
