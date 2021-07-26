#include <bits/stdc++.h>

using namespace std;

class JulySolution {
public:
    int partitionDisjoint(vector<int>& nums) {
        int res = 0;
        int maxTaken = nums[0];
        int maxVal = nums[0];
        
        for(int i = 1; i < nums.size(); i++){
            if(nums[i] < maxTaken){
                maxTaken = maxVal;
                res = i;
            }else{
                maxVal = max(maxVal, nums[i]);
            }
        }

        return res+1;
    }
};