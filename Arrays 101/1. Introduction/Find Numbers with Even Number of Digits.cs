using System;
public partial class Arrays101Solution {
    public int FindNumbers(int[] nums) {
        int q = 0;
        foreach(int num in nums){
            if(num.ToString().Length % 2 == 0){
                q++;
            }
        }

        return q;
    }
}

