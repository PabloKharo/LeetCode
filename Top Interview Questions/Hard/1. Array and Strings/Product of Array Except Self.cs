using System;
using System.Collections.Generic;

public partial class HardInterSolution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] res = new int[nums.Length];
        int val = 1;
        for(int i = 0; i < nums.Length; i++){
            res[i] = val;
            val *= nums[i];
        }

        val = 1;
        for(int i = nums.Length - 1; i >= 0; i--){
            res[i] *= val;
            val *= nums[i];
        }

        return res;
    }

}