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

class JulySolution {
public:

    bool Dfs(TreeNode* node){
        bool left = false;
        bool right = false;
        if(node->left != nullptr){
            left = Dfs(node->left);
            if(!left){
                node->left = nullptr;
            }
        }

        if(node->right != nullptr){
            right = Dfs(node->right);
            if(!right){
                node->right = nullptr;
            }
        }

        if(!left && !right && node->val == 0)
            return false;

        return true;
    }

    TreeNode* pruneTree(TreeNode* root) {
        return (Dfs(root)) ? root : nullptr;
    }
};