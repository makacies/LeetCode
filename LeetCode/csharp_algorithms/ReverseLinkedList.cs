// 206.Reverse Linked List

namespace LeetCode.csharp_algorithms
{
    public static class ReverseLinkedList
    {
        public static ListNode? ReverseList(ListNode? head)
        {
            ListNode? temp = null;

            while (head != null)
            {
                var next = head.next;
                head.next = temp;
                temp = head;
                head = next;
            }

            return temp;
        }
    }
}
