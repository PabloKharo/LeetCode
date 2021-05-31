#include <bits/stdc++.h>

using namespace std;

class MedInterSolution {
public:
    vector<vector<string>> groupAnagrams(vector<string>& strs) {
        unordered_map<string, int> dict;
        vector<vector<string>> res;
        
        for(int i = 0; i < strs.size(); i++){
            string sortedStr = strs[i];
            sort(sortedStr.begin(), sortedStr.end());

            auto search = dict.find(sortedStr);
            if (search != dict.end()) {
                res[search->second].push_back(strs[i]);
            } else {
                dict[sortedStr] = res.size();
                res.push_back({strs[i]});
            }
        }

        return res;
    }
};
