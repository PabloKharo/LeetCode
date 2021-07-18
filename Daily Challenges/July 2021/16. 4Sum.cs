using System;
using System.Linq;
using System.Collections.Generic;

public partial class JulySolution
{
    public IList<IList<int>> FourSum(int[] nums, int target) {
        Array.Sort(nums);
        Dictionary<int, int> dict = new Dictionary<int, int>();
        
        for(int i = 1; i < nums.Length; i++)
        {
            if(nums[i-1] == nums[i])
                continue;

            dict.Add(nums[i-1], i-1);
        }
        dict.Add(nums[^1], nums.Length-1);

        int first, second, third, fourth;
        List<IList<int>> res = new List<IList<int>>();
        for(int i = 0; i < nums.Length - 3; i++)
        {
            if(i > 0 && nums[i] == nums[i-1])
                continue;

            first = nums[i]; 
            for(int j = i+1; j < nums.Length - 2; j++)
            {
                if(j > i+1 && nums[j] == nums[j-1])
                    continue;

                second = nums[j];              
                for(int k = j+1; k < nums.Length - 1; k++)
                {
                    if(k > j+1 && nums[k] == nums[k-1])
                        continue;
                    
                    third = nums[k];    
                    fourth = target - first - second - third;
                    if(fourth >= third && dict.ContainsKey(fourth) && dict[fourth] > k)
                        res.Add(new List<int> {first, second, third, fourth});
                }
            }
        }

        return res;
    }
}