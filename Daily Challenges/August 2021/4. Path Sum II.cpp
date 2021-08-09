#include <bits/stdc++.h>

using namespace std;

struct TreeNode {
    int val;
    TreeNode *left;
    TreeNode *right;
    TreeNode() : val(0), left(nullptr), right(nullptr) {}
    TreeNode(int x) : val(x), left(nullptr), right(nullptr) {}
    TreeNode(int x, TreeNode *left, TreeNode *right) : val(x), left(left), right(right) {}
};

class AugustSolution {
public:
    void dfs(TreeNode* node, int& targetSum, vector<vector<int>>& res, vector<int>& tmpVec, int& curSum){
        tmpVec.push_back(node->val);
        curSum += node->val;
        
        if(node->left == nullptr && node->right == nullptr){
            if(curSum == targetSum)
                res.push_back(tmpVec);

        }else{
            if(node->left != nullptr)
                dfs(node->left, targetSum, res, tmpVec, curSum);
            if(node->right != nullptr)
                dfs(node->right, targetSum, res, tmpVec, curSum);
        }

        curSum -= node->val;
        tmpVec.pop_back();
    }

    vector<vector<int>> pathSum(TreeNode* root, int targetSum) {
        vector<vector<int>> res;
        if(root == nullptr)
            return res;

        vector<int> tmpVec;
        int curSum = 0;

        dfs(root, targetSum, res, tmpVec, curSum);
        return res;
    }
};
