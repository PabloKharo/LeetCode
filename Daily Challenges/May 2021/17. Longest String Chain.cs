using System;
using System.Linq;
using System.Collections.Generic;

public partial class MaySolution {
    public int LongestStrChain(string[] words) {
        int res = 1;
        Array.Sort(words, (x, y) => x.Length.CompareTo(y.Length));
        Dictionary<string, int> dp = new Dictionary<string, int>();

        for(int i = 0; i < words.Length; i++){
            if(words[i].Length == 1){
                if (!dp.ContainsKey(words[i])){
                    dp.Add(words[i], 1);
                }
                continue;
            }

            if(dp.ContainsKey(words[i])){
                continue;
            }

            int maxChain = 1;
            for(int j = 0; j < words[i].Length; j++){
                string str = words[i].Substring(0, j) + words[i].Substring(j+1, words[i].Length - (j + 1));
                if(dp.ContainsKey(str)){
                    maxChain = Math.Max(maxChain, dp[str] + 1);
                }
            }

            res = Math.Max(res, maxChain);
            dp.Add(words[i], maxChain);
        }

        return res;
    }

}