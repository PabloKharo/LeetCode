#include <bits/stdc++.h>

using namespace std;

class HardInterSolution {
public:
    void wiggleSort(vector<int>& nums) {
        vector<int> sorted(nums);
        sort(sorted.begin(), sorted.end());

        int l = 0;
        int r = (nums.size()-1) / 2 + 1;
        for(int i = nums.size() - 1; i >= 0; i--){
            if(i % 2 == 0)
                nums[i] = sorted[l++];
            else
                nums[i] = sorted[r++];
        }
    }
};
