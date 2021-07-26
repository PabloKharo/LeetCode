#include <bits/stdc++.h>

using namespace std;

class MedInterSolution {
public:

    inline int factorial(int n){
        return (n==1 || n==0) ? 1: n * factorial(n - 1);
    }

    void dfs(vector<int>& nums, vector<vector<int>>& res, int len){
        if(len == nums.size()){
            res.push_back(nums);
            return;
        }

        for(int i = len; i < nums.size(); i++){
            swap(nums[i], nums[len]);
            dfs(nums, res, len+1);
            swap(nums[i], nums[len]);
        }

    }

    vector<vector<int>> permute(vector<int>& nums) {
        int n = factorial(nums.size());

        vector<vector<int>> res;
        res.reserve(n * sizeof(vector<int>(nums.size())));

        dfs(nums, res, 0);
        return res;
    }
};