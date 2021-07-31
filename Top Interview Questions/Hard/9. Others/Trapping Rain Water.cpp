#include <bits/stdc++.h>

using namespace std;

class HardInterSolution {
public:
    int trap(vector<int>& height) {
        int maxHeight = 0;
        for(int i = 0; i < height.size(); i++){
            maxHeight = max(maxHeight, height[i]);
        }
        int res = 0;
        int curMax = 0;
        int ind = 0;
        for(; ind < height.size() && height[ind] != maxHeight; ind++){
            curMax = max(height[ind], curMax);
            res += curMax - height[ind];
        }
        curMax = 0;
        for(int i = height.size() - 1; i > ind; i--){
            curMax = max(height[i], curMax);
            res += curMax - height[i];
        }

        return res;
    }
};