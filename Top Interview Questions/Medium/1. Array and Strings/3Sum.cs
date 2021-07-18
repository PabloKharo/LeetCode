using System;
using System.Linq;
using System.Collections.Generic;

public partial class MedInterSolution
{
    public IList<IList<int>> ThreeSum(int[] nums) {
        List<IList<int>> res = new List<IList<int>>();
        if(nums.Length < 3)
            return res;

        Array.Sort(nums);
        Dictionary<int, int> dict = new Dictionary<int, int>();
        
        for(int i = 1; i < nums.Length; i++)
        {
            if(nums[i-1] == nums[i])
                continue;

            dict.Add(nums[i-1], i-1);
        }
        dict.Add(nums[^1], nums.Length-1);

        int first, second, third;
        for(int i = 0; i < nums.Length - 2; i++)
        {
            if(nums[i] > 0)
                break;
            if(i > 0 && nums[i] == nums[i-1])
                continue;

            first = nums[i]; 
            for(int j = i+1; j < nums.Length - 1; j++)
            {
                if(nums[i] + nums[j] > 0)
                break;

                if(j > i+1 && nums[j] == nums[j-1])
                    continue;

                second = nums[j];                 
                third = 0 - first - second;
                if(third >= second && dict.ContainsKey(third) && dict[third] > j)
                    res.Add(new List<int> {first, second, third});
            }
        }

        return res;
    }
}