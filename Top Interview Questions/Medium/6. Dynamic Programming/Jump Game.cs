using System;
using System.Collections.Generic;

public partial class MedInterSolution {
    public bool CanJump(int[] nums) {
        bool[] dp = new bool[nums.Length];
        dp[0] = true;

        for(int i = 0; i < nums.Length; i++){
            if(dp[i] == false)
                continue;

            if(i + nums[i] >= nums.Length - 1){
                return true;
            }

            for(int j = 1; j <= nums[i]; j++){
                dp[i+j] = true;
            }
        }

        return dp[nums.Length - 1];
    }

}