#include <bits/stdc++.h>

using namespace std;

class MedInterSolution {
public:
    struct MyData{
        int key;
        int amount;

        MyData(int _key, int _amount) : key(_key), amount(_amount){}

        bool operator<(const MyData& rhs) const{
            return this->amount < rhs.amount;
        }
    };

    vector<int> topKFrequent(vector<int>& nums, int k) {
        unordered_map<int, int> dict;
        for(const int& val : nums){
            dict[val] += 1;
        }

        priority_queue<MyData> q;
        for(auto [key, val] : dict){
            q.push(MyData(key, val));
        }

        vector<int> res(k);
        for(int i = 0; i < k; i++){
            res[i] = q.top().key; q.pop();
        }

        return res;
    }
};