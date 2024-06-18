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
}
