using System;
using System.Linq;
using System.Collections;

public partial class Arrays101Solution {
    public int HeightChecker(int[] heights) {
        int[] expected = heights.ToArray();
        Array.Sort(expected);
        int res = 0;
        for(int i = 0; i < heights.Length; i++){
            if(heights[i] != expected[i])
                res++;
        }

        return res;
    }
}