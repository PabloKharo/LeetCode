using System;
using System.Collections.Generic;

public partial class MedInterSolution {
    public void SortColors(int[] nums) {
        int zero = 0;
        int one = 0;
        int two = 0;
        foreach(int num in nums){
            if(num == 0)
                zero++;
            else if(num == 1)
                one++;
            else
                two++;
        }

        int i = 0;
        while(i < zero){
            nums[i++] = 0;
        }
        while(i < zero+ one){
            nums[i++] = 1;
        }
        while(i < zero + one + two){
            nums[i++] = 2;
        }
    }

}