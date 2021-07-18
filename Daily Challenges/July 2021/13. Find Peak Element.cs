using System;
using System.Linq;
using System.Collections.Generic;

public partial class JulySolution
{
    public int FindPeakElement(int[] nums) {
        int l = 0;
        int r = nums.Length - 1;
        int m = 0;
        while (l < r) {
            m = (l + r) / 2;
            if (nums[m] < nums[m+1])
                l = m + 1;
            else
                r = m;
        }

        return l;
    }
}