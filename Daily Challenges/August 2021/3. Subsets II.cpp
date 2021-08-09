#include <bits/stdc++.h>

using namespace std;

class AugustSolution {
public:
    void AddVecs(vector<int>& nums, vector<vector<int>>& res, vector<int>& tmpVec, int leftPos){
		res.push_back(tmpVec);
		for (int i = leftPos; i < nums.size(); i++){
            if (i == leftPos || nums[i] != nums[i - 1]){
                tmpVec.push_back(nums[i]);
                AddVecs(nums, res, tmpVec, i + 1);
                tmpVec.pop_back();
            }
		}
    }

    vector<vector<int>> subsetsWithDup(vector<int>& nums) {
        vector<vector<int>> res;
		vector<int> tmpVec;
        tmpVec.reserve(nums.size());

		sort(nums.begin(), nums.end());
		AddVecs(nums, res, tmpVec, 0);
		return res;
    }
};