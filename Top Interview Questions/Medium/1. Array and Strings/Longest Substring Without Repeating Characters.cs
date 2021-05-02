using System;
using System.Collections.Generic;

public partial class MedInterSolution {
    public int LengthOfLongestSubstring(string s) {
        Dictionary<char, int> dict = new Dictionary<char, int>();
        int left = 0;
        int res = 0;

        for(int i = 0; i < s.Length; i++){
            if(dict.ContainsKey(s[i])){
                res = Math.Max(res, i - left);
                while(s[left] != s[i]){
                    dict.Remove(s[left]);
                    left++;
                }
                left++;
            }

            dict[s[i]] = i;
        }

        res = Math.Max(res, s.Length - left);

        return res;
    }
}