#include <bits/stdc++.h>

using namespace std;

class HardInterSolution {
public:
    string largestNumber(vector<int> nums) {
        string res = "";

        sort(nums.begin(), nums.end(),
            [](int lhs, int rhs)
            {
                string lhsS = to_string(lhs);
                string rhsS = to_string(rhs);

                return lhsS + rhsS > rhsS + lhsS;

            });

        int k = 0;
        while(k < nums.size()-1 && nums[k] == 0){
            k++;
        }

        for (int i = k; i < nums.size(); i++) {
            res += to_string(nums[i]);
        }

        return res;
    
    }


    // string largestNumber(vector<int> nums) {
    //     string res = "";

    //     sort(nums.begin(), nums.end(),
    //         [](int lhs, int rhs)
    //         {
    //             int lenL = 0;
    //             int lenR = 0;
    //             int prevL = lhs;
    //             int prevR = rhs;
    //             while (lhs != 0) {
    //                 lhs /= 10;
    //                 lenL++;
    //             }
    //             while (rhs != 0) {
    //                 rhs /= 10;
    //                 lenR++;
    //             }

    //             lenL = pow(10, lenL-1);
    //             lenR = pow(10, lenR-1);
    //             while (prevL != 0 && prevR != 0) {
    //                 if (prevL / lenL != prevR / lenR) {
    //                     return prevL / lenL > prevR / lenR;
    //                 }

    //                 prevL %= lenL;
    //                 lenL /= 10;
    //                 prevR %= lenR;
    //                 lenR /= 10;
    //             }

    //             if (lenL != lenR)
    //                 return lenL < lenR;

    //             return prevL > prevR;

    //         });

    //     int k = 0;
    //     while (k < nums.size() - 1 && nums[k] == 0) {
    //         k++;
    //     }

    //     for (int i = k; i < nums.size(); i++) {
    //         res += to_string(nums[i]);
    //     }

    //     return res;
    // }
};