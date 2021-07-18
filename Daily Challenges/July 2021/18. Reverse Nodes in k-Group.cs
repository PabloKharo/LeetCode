using System;
using System.Linq;
using System.Collections.Generic;

public partial class JulySolution
{
    public ListNode ReverseKGroup(ListNode head, int k) {
        if(k == 1)
            return head;
        
        ListNode res, prevRight, prevLeft, newRight, next;
        ListNode left = head;
        ListNode right = head;
        
        for(int i = 0; i < k; i++)
            right = right.next;
        newRight = right;

        prevRight = left;
        for(int i = 0; i < k; i++)
        {
            next = left.next;
            left.next = newRight;
            newRight = left;
            left = next;
        }
        res = newRight;

        bool toBreak = false;
        while(true)
        {
            for(int i = 0; i < k; i++){
                if(right == null){
                    toBreak = true;
                    break;
                }
                right = right.next;
            }
            prevLeft = left;

            if(toBreak)
                break;
            newRight = right;
            for(int i = 0; i < k-1; i++)
            {
                next = left.next;
                left.next = newRight;
                newRight = left;
                left = next;
            }
            next = left.next;
            prevRight.next = left;
            left.next = newRight;
            left = next;

            prevRight = prevLeft;

        }

        return res;
    }
}