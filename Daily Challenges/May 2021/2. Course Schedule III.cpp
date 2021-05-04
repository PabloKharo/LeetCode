#include "bits/stdc++.h"

using namespace std;


class MaySolution {
public:
    int scheduleCourse(vector<vector<int>>& courses) {
        sort(courses.begin(), courses.end(), 
                [](vector<int>& lhs, vector<int>& rhs)
                    {return lhs[1] < rhs[1];});
        priority_queue<int> lengs;
        int time = 0;

        for(int i = 0; i < courses.size(); i++){
            if(time + courses[i][0] > courses[i][1]){
                if(lengs.size() == 0)
                    continue;
                int maxLen = lengs.top();
                if(maxLen > courses[i][0] && time - maxLen + courses[i][0] <= courses[i][1]){
                    lengs.pop();
                    time -= maxLen;
                    lengs.push(courses[i][0]);
                    time += courses[i][0];
                }
            }else{
                lengs.push(courses[i][0]);
                time += courses[i][0];
            }
        }

        return lengs.size();
        
    }
};