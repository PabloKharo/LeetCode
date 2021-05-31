using System;
using System.Linq;
using System.Collections.Generic;

public partial class MaySolution {

    void AddNodes(ref List<IList<int>> res, TreeNode node, int height){
        if(node == null){
            return;
        }

        if(res.Count <= height){
            res.Add(new List<int>());
        }
        res[height].Add(node.val);

        AddNodes(ref res, node.left, height + 1);
        AddNodes(ref res, node.right, height + 1);

    }
    public IList<IList<int>> LevelOrder(TreeNode root) {
        List<IList<int>> res = new List<IList<int>>();
        AddNodes(ref res, root, 0);

        return res;

    }

}