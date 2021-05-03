using System;
using System.Collections.Generic;
using System.Linq;


public partial class MaySolution {
    public int[] RunningSum(int[] nums) {
        int sum = 0;
        for(int i = 0; i < nums.Length; i++){
            sum += nums[i];
            nums[i] = sum;
        }

        return nums;
    }

}