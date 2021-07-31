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
    TreeNode* makeTree(vector<int>& nums, int left, int right) {
        if (left > right)
            return nullptr;

        TreeNode* node = new TreeNode(nums[(left + right) / 2]);
        node->left = makeTree(nums, left, ((left + right) / 2) - 1);
        node->right = makeTree(nums, ((left + right) / 2) + 1, right);

        return node;
    }

    TreeNode* sortedArrayToBST(vector<int>& nums) {
        TreeNode* node = new TreeNode(nums[nums.size() / 2]);
        node->left = makeTree(nums, 0, (nums.size() / 2) - 1);
        node->right = makeTree(nums, (nums.size() / 2) + 1, nums.size() - 1);

        return node;
    }
};
