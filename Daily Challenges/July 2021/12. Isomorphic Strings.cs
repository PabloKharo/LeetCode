using System;
using System.Linq;
using System.Collections.Generic;

public partial class JulySolution
{
    public bool IsIsomorphic(string s, string t) {
        Dictionary<char, char> dict = new Dictionary<char, char>();
        HashSet<char> usedChars = new HashSet<char>();
        for(int i = 0; i < s.Length; i++)
        {
            if(dict.ContainsKey(s[i]))
            {
                if(dict[s[i]] != t[i])
                    return false;
            }
            else
            {
                if(!usedChars.Contains(t[i]))
                {
                    dict.Add(s[i], t[i]);
                    usedChars.Add(t[i]);
                }
                else return false;
            }
        }

        return true;
    }
}