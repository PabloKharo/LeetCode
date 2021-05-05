using System;
using System.Collections.Generic;

public partial class MedInterSolution {

    Dictionary<char, List<char>> dict = new Dictionary<char, List<char>> {
        ['2'] = new List<char> {'a', 'b', 'c'},
        ['3'] = new List<char> {'d', 'e', 'f'},
        ['4'] = new List<char> {'g', 'h', 'i'},
        ['5'] = new List<char> {'j', 'k', 'l'},
        ['6'] = new List<char> {'m', 'n', 'o'},
        ['7'] = new List<char> {'p', 'q', 'r', 's'},
        ['8'] = new List<char> {'t', 'u', 'v'},
        ['9'] = new List<char> {'w', 'x', 'y', 'z'},
        
    };
    public IList<string> LetterCombinations(string digits) {
        if(digits.Length == 0)
            return new List<string>();

        List<string> res = new List<string>();
        List<string> prev = new List<string>();
        if(digits.Length > 1){
            prev = (List<string>)LetterCombinations(digits.Substring(1));
            foreach(char c in dict[digits[0]]){
                for(int i = 0; i < prev.Count; i++){
                    res.Add(c + prev[i]);
                }
            }
        }else{
            foreach(char c in dict[digits[0]]){
                res.Add(c.ToString());
            }
        }

        return res;
    }

}