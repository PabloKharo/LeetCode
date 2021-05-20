using System;
using System.Collections.Generic;
using System.Linq;

public partial class HardInterSolution {
    public int LongestConsecutive(int[] nums) {
        Dictionary<int, int> dict = new Dictionary<int, int>();
        for(int i = 0; i < nums.Length; i++){
            if(!dict.ContainsKey(nums[i])){
                dict.Add(nums[i], 0);
            }
        }

        foreach((int key, int val) in dict.ToList()){
            if(val != 0){
                continue;
            }

            dict[key] = 1;
            int i = 1;
            while(dict.ContainsKey(key - i)){
                if(dict[key - i] != 0){
                    dict[key] += dict[key - i];
                    dict.Remove(key - i);
                    break;
                }

                dict[key] += 1;
                dict.Remove(key - i);
                i++;
            }
        }

        int res = 0;
        foreach((int _, int val) in dict){
            res = Math.Max(res, val);
        }

        return res;
    }
}
