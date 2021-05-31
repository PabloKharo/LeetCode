using System;
using System.Linq;
using System.Collections.Generic;

public partial class MaySolution {
    public int MinMoves2(int[] nums) {
        Array.Sort(nums);
        int med = nums.Length / 2;
        int res = 0;
        for(int i = 0; i < nums.Length; i++){
            res += Math.Abs(nums[med] - nums[i]);
        }

        return res;
    }

}