using System;
using System.Linq;
using System.Collections.Generic;

public partial class EasyInterSolution
{
    public int SingleNumber(int[] nums) {
        Dictionary<int, bool> dict = new Dictionary<int, bool>();
        for(int i = 0; i < nums.Length; i++)
        {
            if(dict.ContainsKey(nums[i]))
                dict[nums[i]] = true;
            else
                dict.Add(nums[i], false);
        }

        foreach(var val in dict)
        {
            if(val.Value == false)
                return val.Key;
        }

        return 0;
    }
}