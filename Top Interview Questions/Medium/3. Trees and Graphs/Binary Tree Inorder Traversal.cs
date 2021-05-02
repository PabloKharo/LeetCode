using System;
using System.Collections.Generic;

public partial class MedInterSolution {
    public IList<int> InorderTraversal(TreeNode root) {
        List<int> res = new List<int>();
        Stack<TreeNode> nodes = new Stack<TreeNode>();
        TreeNode curNode = root;

        while(nodes.Count != 0 || curNode != null){
            while(curNode != null){
                nodes.Push(curNode);
                curNode = curNode.left;
            }
            curNode = nodes.Pop();
            res.Add(curNode.val);
            curNode = curNode.right;
        }


        return res;
    }


}