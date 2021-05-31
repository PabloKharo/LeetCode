using System;
using System.Collections.Generic;

public partial class EasyInterSolution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> dict = new Dictionary<int, int>();

        int left = 0;
        int right = 0;

        for(int i = 0; i < nums.Length; i++){
            if(dict.ContainsKey(target - nums[i])){
                left = dict[target - nums[i]];
                right = i;
                break;
            }

            dict[nums[i]] = i;
        }

        return new int[] {left, right};        
    }

}