using System;
using System.Linq;
using System.Collections.Generic;

public partial class HardInterSolution
{
    TreeNode P;
    TreeNode Q;
    TreeNode Dfs(TreeNode node){

        if(node.left != null && node.right != null)
        {
            TreeNode left = new TreeNode();
            left = Dfs(node.left);

            if(left != P && left != Q && left != null) 
                return left;

            TreeNode right = new TreeNode();
            right = Dfs(node.right);

            if(right != P && right != Q && right != null) 
                return right;

            if(left == null && right == null)
            {
                if(node == P || node == Q)
                    return node;
                return null;
            }

            if(left != null && right != null) 
                return node;

            if(left != null && (node == Q || node == P)) 
                return node;
            
            if(right != null && (node == Q || node == P)) 
                return node;

            return (left != null) ? left : right;

        }
        else if(node.left != null)
        {
            TreeNode left = new TreeNode();
            left = Dfs(node.left);

            if(left != P && left != Q && left != null)
                return left;

            if(left != null && (node == Q || node == P)) 
                return node;
            
            if(left == null)
            {
                if(node == P || node == Q)
                    return node;
                return null;
            }
            else
            {
                return left;
            }

            
        }
        else if(node.right != null)
        {
            TreeNode right = new TreeNode();
            right = Dfs(node.right);

            if(right != P && right != Q && right != null)
                return right;

            if(right != null && (node == Q || node == P)) 
                return node;
            
            if(right == null)
            {
                if(node == P || node == Q)
                    return node;
                return null;
            }
            else
            {
                return right;
            }
        }
        else
        {
            if(node == P || node == Q)
                return node;
            return null;
        }
    }
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
        P = p;
        Q = q;

        return Dfs(root);
    }
}