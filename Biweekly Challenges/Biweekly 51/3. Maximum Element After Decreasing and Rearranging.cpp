#include "bits/stdc++.h"

using namespace std;

class Biweek51Solution {
public:
    int maximumElementAfterDecrementingAndRearranging(vector<int>& arr) {
        priority_queue<int, vector<int>, greater<int>> ms;

        for(int i = 0; i < arr.size(); i++){
            ms.push(arr[i]);
        }
        int max = 1;
        arr[0] = ms.top(); ms.pop();
        if(arr[0] != 1)
            arr[0] = 1;

        for(int i = 1; i < arr.size(); i++){
            arr[i] = ms.top(); ms.pop();
            if(arr[i-1] + 1 < arr[i]){
                arr[i] = arr[i-1] + 1;
            }else if(arr[i-1] - 1 > arr[i]){
                arr[i] = arr[i-1] - 1;
            }

            if(arr[i] > max){
                max = arr[i];
            }
        }

        return max;
    }
};