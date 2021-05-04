
using System;
using System.Collections.Generic;
using System.Linq;


public partial class MaySolution {
    public class WordFilter {

        Dictionary<string, int> dict;
        public WordFilter(string[] words) {
            dict = new Dictionary<string, int>();
            for(int i = 0; i < words.Length; i++){
                for (int j = 0; j <= words[i].Length; j++) {
                    for (int k = 0; k < words[i].Length; k++) {
                        string suff = words[i].Substring(0, j);
                        string preff = words[i].Substring(k, words[i].Length-k);
                        dict[suff + '$' + preff] = i;
                    }
                }
            }
        }
        public int F(string prefix, string suffix) {
            string s = prefix + '$' + suffix;
            if(dict.ContainsKey(s)){
                return dict[s];
            } 
            return -1;
        }
        /**
        * Your WordFilter object will be instantiated and called as such:
        * WordFilter obj = new WordFilter(words);
        * int param_1 = obj.F(prefix,suffix);
        */

    }
}
