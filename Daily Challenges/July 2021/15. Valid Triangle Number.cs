using System;
using System.Linq;
using System.Collections.Generic;

public partial class JulySolution
{
    public int TriangleNumber(int[] nums) {
        if(nums.Length < 3)
            return 0;


        Array.Sort(nums);
        int res = 0;

        for(int i = 0; i < nums.Length - 1; i++)
        {
            for(int j = i+1; j < nums.Length - 1; j++)
            {
                for(int k = j+1; k < nums.Length; k++)
                {
                    if(nums[i] + nums[j] <= nums[k])
                        break;
                    res++;
                }
            }
        }

        return res;
    }
}