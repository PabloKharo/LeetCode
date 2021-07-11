using System;
using System.Linq;
using System.Collections.Generic;

public partial class JulySolution
{
    public int MinSetSize(int[] arr) {
        Dictionary<int, int> dict = new();
        int n = arr.Length;
        for (int i = 0; i < n; i++) 
        {
            if (dict.ContainsKey(arr[i]))
                dict[arr[i]] += 1;
            else
                dict.Add(arr[i], 1);
        }

        int curCount = 0;
        int res = 0;
        foreach (int count in dict.Values.OrderByDescending(val => val)){
            if (curCount * 2 >= n)
                break;
            curCount += count;
            ++res;
        }

        return res;
    }
}