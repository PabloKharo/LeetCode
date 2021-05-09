using System;
using System.Collections.Generic;

public partial class MedInterSolution {

    void GenerateSkob(int n, int open, int close, string str, ref List<string> list){
        if(str.Length == 2*n){
            list.Add(str);
            return;
        }
        
        if(open < n){
            GenerateSkob(n, open + 1, close, str+'(', ref list);
        }
        if(close < open){
            GenerateSkob(n, open, close + 1, str+')', ref list);
        }
    }

    public IList<string> GenerateParenthesis(int n) {
        List<string> res = new List<string>();
        GenerateSkob(n, 0, 0, "", ref res);

        return res;
    }


}