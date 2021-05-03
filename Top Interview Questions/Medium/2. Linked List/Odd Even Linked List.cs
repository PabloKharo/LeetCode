using System;
using System.Collections.Generic;

public partial class MedInterSolution {
    public ListNode OddEvenList(ListNode head) {
        if(head == null || head.next == null)
            return head;
        ListNode curNode = head;
        ListNode nextNode = head.next;

        ListNode firstLeft = head;
        ListNode curLeft = head;

        ListNode firstRight = head.next;
        ListNode curRight = head.next;

        curNode = head.next.next;
        int i = 1;
        while(curNode != null){
            nextNode = curNode.next;
            if(i % 2 == 0){
                curRight.next = curNode;
                curRight = curNode;
            }else{
                curLeft.next = curNode;
                curLeft = curNode;
            }
            curNode = nextNode;
            i++;
        }
        curRight.next = null;

        curLeft.next = firstRight;
        return firstLeft;
    }


}