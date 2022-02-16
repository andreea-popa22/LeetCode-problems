public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        if (list1 == null)
            return list2;
        if (list2 == null)
            return list1;
        
        ListNode sorted = new ListNode();
        ListNode aux = sorted;
        
        while(list1 != null && list2 != null)
        {
            if (list1.val <= list2.val)
            {
                sorted.next = list1;
                list1 = list1.next;
            }
            else
            {
                sorted.next = list2;
                list2 = list2.next;
            }
            
            sorted = sorted.next;
        }
        
        if (list1 != null)
            sorted.next = list1;
        if (list2 != null)
            sorted.next = list2;
        
        return aux.next;
    }