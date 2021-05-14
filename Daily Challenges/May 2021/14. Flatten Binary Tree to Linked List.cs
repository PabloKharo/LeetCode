using System;
using System.Linq;
using System.Collections.Generic;

public partial class MaySolution {
    public void Flatten(TreeNode root) {
        TreeNode cur = root;
        while(cur != null){
            if(cur.left != null){
                TreeNode next = cur.left;
				while(next.right != null){
					next = next.right;
				}
				next.right = cur.right;
                
				cur.right = cur.left;
				cur.left = null;
            }

            cur = cur.right;
        }
    }

}