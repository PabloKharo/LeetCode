#include <bits/stdc++.h>

using namespace std;

class Biweek58Solution {
public:
    string makeFancyString(string s) {
        if(s.length() < 3)
            return s;

        string res = "";
        res += s[0];
        res += s[1];
        for(int i = 2; i < s.size(); i++){
            if(s[i-1] != s[i] || s[i-2] != s[i]){
                res += s[i];
            }
        }

        return res;
    }
};