// 226. Invert Binary Tree

namespace LeetCode
{
    internal class InvertBinaryTree
    {
        internal TreeNode InvertTree(TreeNode root)
        {
            Swap(root);
            return root;

            void Swap(TreeNode? node)
            {
                if (node == null)
                {
                    return;
                }

                (node.left, node.right) = (node.right, node.left);
                Swap(node.left);
                Swap(node.right);
            }
        }

    }


    public class TreeNode(int val = 0, TreeNode? left = null, TreeNode? right = null)
    {
        public int val = val;
        public TreeNode? left = left;
        public TreeNode? right = right;
    }
}
