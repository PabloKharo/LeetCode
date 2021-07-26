#include <bits/stdc++.h>

using namespace std;

class HardInterSolution {
public:
    int maxProduct(vector<int>& nums) {
        int prod = 1;
        int res = nums[0];
        for(int i = 0; i < nums.size(); i++){
            prod *= nums[i];
            res = max(res, prod);
            if(prod == 0)
                prod = 1;
        }

        prod = 1;
        for(int i = nums.size()-1; i >= 0; i--){
            prod *= nums[i];
            res = max(res, prod);
            if(prod == 0)
                prod = 1;
        }


        return res;
    }
};