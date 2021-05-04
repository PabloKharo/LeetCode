#include "bits/stdc++.h";

using namespace std;

class AprilCppSolution {
public:
    int furthestBuilding(vector<int>& heights, int bricks, int ladders) {
        int usedBricks = 0;
        int res = 0;
    
        priority_queue<int, vector<int>, greater<int>> q;

        for(int i = 0; i < heights.size() - 1; i++){
            int diff = heights[i+1] - heights[i];
            if(diff > 0){
                if(q.size() != ladders){
                    q.push(diff);
                }else{
                    if(q.size() != 0 && q.top() < diff){
                        usedBricks += q.top();
                        q.pop();
                        q.push(diff);
                    }else{
                        usedBricks += diff;
                    }

                    if(usedBricks > bricks){
                        break;
                    }

                }
            }
            res++;
        }

        return res;
    }
};