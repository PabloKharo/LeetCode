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

class MedInterSolution {
public:

    int Dfs(TreeNode* node, int& k, int& count){
        int val = -1;
        if(node->left != nullptr){
            val = Dfs(node->left, k, count);
            if(val != -1)
                return val;
        }

        count += 1;
        if(count == k)
            return node->val;
        
        return (node->right == nullptr) ? -1 : Dfs(node->right, k, count);
    }

    int kthSmallest(TreeNode* root, int k) {
        int count = 0;
        return Dfs(root, k, count);
    }
};