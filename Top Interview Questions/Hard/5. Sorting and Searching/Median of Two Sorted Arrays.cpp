#include <bits/stdc++.h>

using namespace std;

class HardInterSolution {
public:

    void plusOne(vector<int>& nums1, vector<int>& nums2, int& left1, int& left2){
        if(left1 < nums1.size() && left2 < nums2.size()){
            if(nums1[left1] < nums2[left2]){
                left1++;
            }else{
                left2++;
            }
        }else if(left1 < nums1.size()){
            left1++;
        }else if(left2 < nums2.size()){
            left2++;
        }
    }

    int getMinVal(vector<int>& nums1, vector<int>& nums2, int& left1, int& left2){
        if(left1 < nums1.size() && left2 < nums2.size()){
            if(nums1[left1] < nums2[left2]){
                return nums1[left1];
            }else{
                return nums2[left2];
            }
        }else if(left1 < nums1.size()){
            return nums1[left1];
        }else if(left2 < nums2.size()){
            return nums2[left2];
        }
        
        return 0;
    }

    double findMedianSortedArrays(vector<int>& nums1, vector<int>& nums2) {
        double res = 0;
        int left1 = 0, left2 = 0;
        int med = (nums1.size() + nums2.size() - 1) / 2;
        while(left1 + left2 < med){
            plusOne(nums1, nums2, left1, left2);
        }
        res = getMinVal(nums1, nums2, left1, left2);

        if((nums1.size() + nums2.size() - 1) % 2 != 0){
            plusOne(nums1, nums2, left1, left2);
            res = (res + getMinVal(nums1, nums2, left1, left2)) / 2;
        }

        return res;
    }
};