using System;
using System.Collections.Generic;

public partial class MedInterSolution {
    public int LengthOfLIS(int[] nums) {
        int[] dp = new int[nums.Length];

        for(int i = 0; i < nums.Length; i++){
            int maxVal = 1;
            for(int j = i - 1; j >= 0; j--){
                if(nums[i] > nums[j]){
                    maxVal = Math.Max(maxVal, dp[j] + 1);
                }
            }
            dp[i] = maxVal;
        }


        int res = 1;
        foreach(int num in dp){
            res = Math.Max(res, num);
        }

        return res;
    }

}