// 235. Lowest Common Ancestor of a Binary Search Tree

namespace LeetCode
{
    internal static class LowestCommonAncestor
    {
        internal static TreeNode Find(TreeNode root, TreeNode p, TreeNode q)
        {
            if (root == null) return null;
            if (root.val == p.val || root.val == q.val) return root;

            var left = Find(root.left, p, q);
            var rigth = Find(root.right, p, q);

            if (left == null || rigth == null) return root;

            return left == null ? rigth : left;
        }
    }
}
