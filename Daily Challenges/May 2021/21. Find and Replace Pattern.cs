using System;
using System.Linq;
using System.Collections.Generic;

public partial class MaySolution {
    public IList<string> FindAndReplacePattern(string[] words, string pattern) {
        List<string> res = new List<string>();
        foreach(string word in words){
            Dictionary<char, char> dict = new Dictionary<char, char>();
            bool[] used = new bool[26];
            bool ok = true;
            for(int i = 0; i < word.Length; i++){
                if (!dict.ContainsKey(pattern[i])){
                    if(used[word[i] - 'a'] == true){
                        ok = false;
                        break;
                    }

                    dict.Add(pattern[i], word[i]);
                    used[word[i] - 'a'] = true;
                }else if(dict[pattern[i]] != word[i]){
                    ok = false;
                    break;
                }
            }
            if(ok == true){
                res.Add(word);
            }

        }
        return res;
    }
}