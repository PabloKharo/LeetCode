using System;
using System.Linq;
using System.Collections.Generic;

public partial class JulySolution
{
    public int LengthOfLIS(int[] nums) {
        List<int> l = new List<int>();
        foreach (int num in nums)
        {
            bool changed = false;
            for(int i = 0; i < l.Count; ++i)
            {
                if(num <= l[i])
                {
                    changed = true;
                    l[i] = num;
                    break;
                }
            }
            if(!changed)
                l.Add(num);

        }

        return l.Count;
    }
}