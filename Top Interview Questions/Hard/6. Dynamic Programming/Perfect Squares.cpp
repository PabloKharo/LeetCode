#include <bits/stdc++.h>

using namespace std;

class HardInterSolution {
public:
    vector<int> vec;

    int countNum(int n) {
        if (vec[n] != INT_MAX)
            return vec[n];

        int minVal = INT_MAX;
        for (int i = sqrt(n); i >= 1; i--) {
            minVal = min(minVal, countNum(n - i * i) + 1);
        }
        vec[n] = minVal;
        return minVal;

    }

    int numSquares(int n) {
        vec.resize(n + 1, INT_MAX);
        vec[0] = 0;
        for (int i = 1; i <= sqrt(n); i++) {
            vec[i * i] = 1;
        }

        return countNum(n);
    }
};
