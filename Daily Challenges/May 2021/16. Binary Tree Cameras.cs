using System;
using System.Linq;
using System.Collections.Generic;

public partial class MaySolution {

    int res;
    public int MinCameraCover(TreeNode root) {
        res = 0;

        DFS(root, null);
        return res;
    }

    void DFS(TreeNode node, TreeNode par){
        if(node != null){
            DFS(node.left, node);
            DFS(node.right, node);

            if(par == null && node.val == 0){
                res++;
                return;
            }

            if(node.left == null && node.right == null){
                if(par == null){
                    res++;
                    node.val = 1;
                }
            }else if(node.right == null){
                if(node.left.val == 0){
                    res++;
                    node.val = 1;
                    if(par != null){
                        par.val = 1;
                    }
                }
            }else if(node.left == null){
                if(node.right.val == 0){
                    res++;
                    node.val = 1;
                    if(par != null){
                        par.val = 1;
                    }
                }
            }else if(node.left.val == 0 || node.right.val == 0){
                res++;
                node.val = 1;
                if(par != null){
                    par.val = 1;
                }
            }

        }
    }

}
