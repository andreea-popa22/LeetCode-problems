public ListNode DeleteDuplicates(ListNode head) {
        if (head == null || head.next == null)
            return head;
        
        ListNode last = head, curr = head.next;
        while (curr != null)
        {
            if (curr.val == last.val)
            {
                last.next = curr.next;
                curr = curr.next;
            }
            else
            {
                last = curr;
                curr = curr.next;
            }
        }
        return head;
    }