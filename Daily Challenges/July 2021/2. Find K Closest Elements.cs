using System;
using System.Linq;
using System.Collections.Generic;

public partial class JulySolution {
    public IList<int> FindClosestElements(int[] arr, int k, int x) {
        List<int> res = new();
        int l = 0;
        int r = arr.Length - 1;
        int m = 0;
        while(l <= r)
        {
            m = (l + r) / 2;
            if(arr[m] < x)
                l = m + 1;
            else if(arr[m] > x)
                r = m - 1;
            else
                break;
        }

        if(m <= 0)
            l = 0;
        else
            l = m - 1;

        r = l + 1;
        
        for(int i = 0; i < k; i++)
        {
            if(l >= 0 && r < arr.Length)
            {
                if(Math.Abs(arr[l] - x) > Math.Abs(arr[r] - x))
                    r++;
                else
                    l--;
            }
            else if(l < 0 && r < arr.Length)
                r++;
            else if(l >= 0 && r >= arr.Length)
                l--;
            else
                break;  
        }

        for(int i = l + 1; i < r; i++)
            res.Add(arr[i]);

        return res;
    }
}