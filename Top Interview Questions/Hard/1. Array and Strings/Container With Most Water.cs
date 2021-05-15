using System;
using System.Collections.Generic;

public partial class HardInterSolution {
    public int MaxArea(int[] height) {
        int res = 0;
        int left = 0;
        int right = height.Length - 1;
        while (left < right) {
            res = Math.Max(res, (right - left) * Math.Min(height[left], height[right]));
            if (height[left] <= height[right]){
                left++;
            }else{
                right--;
            }
        }
        return res;
    }


}