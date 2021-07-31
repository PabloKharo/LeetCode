#include <bits/stdc++.h>

using namespace std;

class JulySolution {
public:
    int threeSumClosest(vector<int>& nums, int target) {
        sort(nums.begin(), nums.end());

        int res = -10000;
        auto lowerRes = lower_bound(nums.begin(), nums.begin(), 0);

        for (int i = 0; i < nums.size() - 2; i++) {
            for (int j = i + 1; j < nums.size() - 1; j++) {
                lowerRes = lower_bound(nums.begin() + j + 1, nums.end(), target - nums[i] - nums[j]);
                if (distance(nums.begin(), lowerRes - 1) > j && abs(target - res) > abs(target - nums[i] - nums[j] - *(lowerRes - 1))) {
                    res = nums[i] + nums[j] + *(lowerRes - 1);

                }

                if (lowerRes != nums.end()) {
                    if(abs(target - res) > abs(target - nums[i] - nums[j] - *lowerRes))
                        res = nums[i] + nums[j] + *lowerRes;
                    if(lowerRes + 1 != nums.end() && abs(target - res) > abs(target - nums[i] - nums[j] - *(lowerRes + 1)))
                        res = nums[i] + nums[j] + *(lowerRes+1);
                }


            }
        }

        return res;
    }
};