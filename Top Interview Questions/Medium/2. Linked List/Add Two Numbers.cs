using System;

public partial class MedInterSolution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        int rem = 0;
        ListNode lRes = new ListNode();
        ListNode curNode = lRes;
        curNode.next = curNode;

        while(l1 != null || l2 != null){
            curNode = curNode.next;
            
            int sum = rem;
            if(l1 != null){
                sum += l1.val;
                l1 = l1.next;
            }
            if(l2 != null){
                sum += l2.val;
                l2 = l2.next;
            }

            curNode.val = sum % 10;
            rem = sum / 10;

            curNode.next = new ListNode();
        }

        if(rem != 0){
            curNode = curNode.next;
            curNode.val = 1;
        }
        curNode.next = null;

        return lRes;
        
    }
}