// 21. Merge Two Sorted Lists

namespace LeetCode;

public class LinkedList
{
    public ListNode? MergeTwoLists(ListNode? list1, ListNode? list2)
    {
        var tail = new ListNode();
        var head = tail;

        while (list1 != null || list2 != null)
        {
            tail.next = new ListNode();
            tail = tail.next;

            if (list1 == null && list2 != null)
            {
                tail.val = list2.val;
                list2 = list2.next;
            }
            else if (list2 == null && list1 != null)
            {
                tail.val = list1.val;
                list1 = list1.next;
            }
            else if (list2.val <= list1.val)
            {
                tail.val = list2.val;
                list2 = list2.next;
            }
            else if (list1.val <= list2.val)
            {
                tail.val = list1.val;
                list1 = list1.next;
            }
        }

        return head.next;
    }
}

public class ListNode(int val = 0, ListNode? next = null)
{
    public int val = val;
    public ListNode? next = next;

    public override string ToString()
    {
        return $"ListNode: val = {val}, next = {next}";
    }
}
