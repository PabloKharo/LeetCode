using System;
using System.Linq;
using System.Collections;

public partial class Arrays101Solution {
    public int ThirdMax(int[] nums) {
        long max1 = long.MinValue;
        long max2 = long.MinValue;
        long max3 = long.MinValue;

        for(int i = 0; i < nums.Length; i++){
            if(nums[i] > max1){
                max3 = max2;
                max2 = max1;
                max1 = nums[i];
            }else if(nums[i] > max2 && nums[i] != max1){
                max3 = max2;
                max2 = nums[i];
            }else if(nums[i] > max3 && nums[i] != max1 && nums[i] != max2){
                max3 = nums[i];
            }
        }

        if(max3 == long.MinValue){
            return (int)max1;
        }
        return (int)max3;
    }
}