#include <bits/stdc++.h>

using namespace std;

class AugustSolution {
public:
    bool canReorderDoubled(vector<int>& arr) {
        sort(arr.begin(), arr.end(), [](const int lhs, const int rhs){
            return abs(lhs) < abs(rhs); });

        unordered_map<int, int> dict;
        for(int i = 0; i < arr.size(); i++){
            dict[arr[i]] += 1;
        }

        for(int i = 0; i < arr.size(); i++){
            if(dict[arr[i]] == 0) 
                continue;

            if(dict[2*arr[i]] == 0) 
                return false;

            dict[arr[i]]--; 
            dict[2*arr[i]]--;
        }

        return true;
    }
};