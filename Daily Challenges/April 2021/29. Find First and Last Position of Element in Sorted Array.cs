using System;
using System.Collections.Generic;

public partial class AprilSolution {
    public int[] SearchRange(int[] nums, int target) {
        if(nums.Length == 0){
            return new int[] {-1,-1};
        }

        int left = 0;
        int right = nums.Length - 1;
        int med = 0;

        while(left <= right){
            med = (left + right) / 2;
            if(nums[med] == target)
                break;
            else if(nums[med] < target)
                left = med + 1;
            else if(nums[med] > target)
                right = med - 1;
        }

        if(nums[med] != target){
            return new int[] {-1,-1};
        }

        int[] res = new int[2];

        int leftPos = med;
        int rightPos = med;

        while(left <= leftPos){
            med = (left + leftPos) / 2;
            if (nums[med] == target) {
                res[0] = med;
                leftPos = med - 1;
            }
            else
                left = med + 1;
        }

        while(rightPos <= right){
            med = (right + rightPos) / 2;
            if (nums[med] == target)
            {
                res[1] = med;
                rightPos = med + 1;
            }
            else
                right = med - 1;
        }

        return res;
    }

}