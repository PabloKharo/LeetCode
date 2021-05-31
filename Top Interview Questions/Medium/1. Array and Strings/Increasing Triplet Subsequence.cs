using System;
using System.Collections.Generic;

public partial class MedInterSolution {

    public bool IncreasingTriplet(int[] nums) {
        long max1 = long.MaxValue;
        long max2 = long.MaxValue;

        for(int i = 0; i < nums.Length; i++){
            if(nums[i] <= max1){
                max1 = nums[i];
            }else if(nums[i] <= max2){
                max2 = nums[i];
            }else{
                return true;
            }
        }

        return false;
    }

}