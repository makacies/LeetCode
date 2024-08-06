// 876. Middle of the Linked List

namespace LeetCode
{
    internal static class MiddleOfTheLinkedList
    {
        internal static ListNode MiddleNode(ListNode head)
        {
            var count = 0;
            var current = head;
            while (current != null)
            {
                count++;
                current = current.next;
            }

            var mid = count / 2 + 1;

            for (var i = 0; i < mid; i++)
            {
                if (i == 0) continue;
                head = head.next;
            }

            return head;
        }
    }
}
