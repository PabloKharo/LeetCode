using System;
using System.Collections.Generic;

public partial class MaySolution {
    public int Jump(int[] nums) {
        if (nums.Length == 1)
            return 0;
        int[] paths = new int[nums.Length];
        for(int i = 1; i < paths.Length; i++){
            paths[i] = Int32.MaxValue;
        }

        for(int i = 0; i < nums.Length; i++){
            for(int j = 1; i+j <= Math.Min(i + nums[i], nums.Length - 1); j++){
                paths[i+j] = Math.Min(paths[i] + 1, paths[i+j]);
            }
        }

        return paths[nums.Length - 1];
    }

}