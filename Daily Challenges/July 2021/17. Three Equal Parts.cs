using System;
using System.Linq;
using System.Collections.Generic;

public partial class JulySolution
{
    public int[] ThreeEqualParts(int[] arr) {
        List<int> ones = new List<int>();
        for(int ind = 0; ind < arr.Length; ind++)
        {
            if(arr[ind] == 1)
                ones.Add(ind);
        }

        if(ones.Count % 3 != 0)
            return new int[] {-1, -1};

        if(ones.Count == 0)
            return new int[] {0, 2};
        
        int i = 0;
        int j = ones.Count / 3;
        int k = j * 2;
        
        int diff_i, diff_j, diff_k;

        for(int ind = 1; ind < ones.Count / 3; ind++)
        {
            diff_i = ones[i+ind] - ones[i+ind-1];
            diff_j = ones[j+ind] - ones[j+ind-1];
            diff_k = ones[k+ind] - ones[k+ind-1];

            if(diff_i != diff_j || diff_j != diff_k || diff_i != diff_k)
                return new int[] {-1, -1};
        }
        
        int count = 0;
        for(int ind = arr.Length - 1; ind > 0; ind--)
        {
            if (arr[ind] == 1)
            {
                count = arr.Length - 1 - ind;
                break;
            }
        }

        if(ones[j] - ones[j-1] > count && ones[k] - ones[k-1] > count)
            return new int[] {ones[j-1] + count, ones[k-1] + count + 1};
        else
            return new int[] {-1, -1};

    }
}