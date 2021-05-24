using System;
using System.Linq;
using System.Collections.Generic;

public partial class MaySolution {
    public string ToLowerCase(string s) {
        string res = "";
        for(int i = 0; i < s.Length; i++){
            if(s[i] >= 'A' && s[i] <= 'Z'){
                res += (char)(s[i] + 32);
            }else{
                res += (char)s[i];
            }
        }

        return res;
    }
}