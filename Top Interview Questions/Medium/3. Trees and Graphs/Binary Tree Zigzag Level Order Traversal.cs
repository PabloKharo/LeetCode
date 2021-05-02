using System;
using System.Collections.Generic;
using System.Linq;

public partial class MedInterSolution {
    public IList<IList<int>> ZigzagLevelOrder(TreeNode root) {
        List<IList<int>> res = new List<IList<int>>();
        if(root == null)
            return res;
        List<TreeNode> curLevel = new List<TreeNode>();
        List<TreeNode> nextLevel = new List<TreeNode>();

        int height = 0;
        curLevel.Add(root);
        while(true){
            res.Add(new List<int>());
            for(int i = curLevel.Count - 1; i >= 0; i--){
                res[height].Add(curLevel[i].val);

                if(height % 2 == 0){ // слева направо
                    if(curLevel[i].left != null)
                        nextLevel.Add(curLevel[i].left);
                    if(curLevel[i].right != null)
                        nextLevel.Add(curLevel[i].right);
                }else{
                    if(curLevel[i].right != null)
                        nextLevel.Add(curLevel[i].right); 
                    if(curLevel[i].left != null)
                        nextLevel.Add(curLevel[i].left);
                }
            }

            if(nextLevel.Count == 0)
                break;
            curLevel = nextLevel.ToList();
            nextLevel.Clear();
            height++;
        }


        return res;
    }
}