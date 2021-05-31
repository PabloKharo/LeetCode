using System;
using System.Collections.Generic;

public partial class MaySolution {

    TreeNode CreateTree(int left, int right, ListNode leftNode){
        if(left > right){
            return null;
        }

        int med = (left + right + 1)/2;
        TreeNode newNode = new TreeNode();
        newNode.left = CreateTree(left, med - 1, leftNode);

        for(int i = left; i < med; i++){
            leftNode = leftNode.next;
        }

        newNode.val = leftNode.val;
        leftNode = leftNode.next;

        newNode.right = CreateTree(med+1, right, leftNode);

        return newNode;
    }
    public TreeNode SortedListToBST(ListNode head) {
        if(head == null)
            return null;

        int count = 0;
        ListNode curNode = head;
        while(curNode != null){
            count++;
            curNode = curNode.next;
        }

        return CreateTree(0, count - 1, head);
    }


}