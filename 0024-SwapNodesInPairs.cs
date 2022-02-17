public ListNode SwapPairs(ListNode head) {
	if (head == null)
		return head;
	
	ListNode aux = head;
	ListNode h1 = aux;
	ListNode h2 = aux.next;
	
	while (h2 != null)
	{
		var s = h1.val;
		h1.val = h2.val;
		h2.val = s;
		
		if (h2.next == null)
			break;
		
		h1 = h1.next.next;
		h2 = h2.next.next;
	}
	
	return head;
}