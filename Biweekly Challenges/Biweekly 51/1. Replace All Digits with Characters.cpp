#include "bits/stdc++.h"

using namespace std;

class Biweek51Solution {
public:
    string replaceDigits(string s) {
        for(int i = 0; i < s.size(); i++){
            if(s[i] >= '0' && s[i] <= '9'){
                s[i] = (char)(s[i - 1] + (int)(s[i] - '0'));
            }
        }
        return s;
    }
};
