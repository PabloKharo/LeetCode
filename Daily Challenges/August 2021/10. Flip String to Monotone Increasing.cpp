#include <bits/stdc++.h>

using namespace std;

class AugustSolution {
public:
    int minFlipsMonoIncr(string s) {
        int leftPos = -1;
        int zeros = 0;
        int ones = 0;

        for(int i = 0; i < s.size(); i++){
            if(s[i] == '0'){
                if(leftPos != -1)
                    zeros++;
            }else{
                if(leftPos == -1)
                    leftPos = i;
            }
        }
        
        int res = zeros;
        for(int i = leftPos; i < s.size(); i++){
            if(s[i] == '0'){
                zeros--;
            }else{
                res = min(res, zeros + ones);
                ones++;
            }
        }
        res = min(res, zeros + ones);


        return res;
    }
};