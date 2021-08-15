#include <bits/stdc++.h>

using namespace std;

class AugustSolution {
public:
    string addStrings(string num1, string num2) {
        string res = "";
        bool addOne = false;
        int i1, i2, val;
        for(int i = 0; i < max(num1.size(), num2.size()); i++){
            i1 = (i < num1.size()) ? num1[num1.size() - i - 1] - '0' : 0;
            i2 = (i < num2.size()) ? num2[num2.size() - i - 1] - '0' : 0;

            val = i1 + i2;
            if(addOne){
                val += 1;
                addOne = false;
            }
            if(val >= 10){
                addOne = true;
                val %= 10;
            }

            res.push_back(val + '0');
        }
        
        if(addOne)
            res.push_back('1');

        reverse(res.begin(), res.end());
        return res;
    }
};