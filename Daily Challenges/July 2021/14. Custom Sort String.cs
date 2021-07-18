using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
public partial class JulySolution
{
    public string CustomSortString(string order, string str) {
        int[] dict = new int[26];
        for(int i = 0; i < str.Length; i++)
            dict[str[i] - 'a'] += 1;


        StringBuilder res = new StringBuilder();
        for(int i = 0; i < order.Length; i++)
        {
            while(dict[order[i] - 'a'] != 0)
            {
                res.Append(order[i]);
                dict[order[i] - 'a'] -= 1;
            }
        }

        for(int i = 0; i < 26; i++)
        {
            while(dict[i] != 0)
            {
                res.Append((char)(i + 'a'));
                dict[i] -= 1;
            }
        }

        return res.ToString();
    }
}