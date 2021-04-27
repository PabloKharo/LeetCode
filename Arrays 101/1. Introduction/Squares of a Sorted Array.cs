using System;
public partial class Arrays101Solution {
    public int[] SortedSquares(int[] nums) {
        int divider = -1;
        for(int i = 0; i < nums.Length; i++){
            if(nums[i] >= 0){
                divider = i;
                break;
            }
        }

        if(divider == -1){
            divider = nums.Length;
        }

        int[] resNums = new int[nums.Length];
        int left = divider-1;
        int right = divider;
        int pos = 0;
        while(left >= 0 && right < nums.Length){
            int powedLeft = nums[left] * nums[left];
            int powedRight = nums[right] * nums[right];
            if(powedLeft < powedRight){
                resNums[pos++] = powedLeft;
                left--;
            }else{
                resNums[pos++] = powedRight;
                right++;
            }
        }

        while(left >= 0){
            resNums[pos++] = nums[left] * nums[left];
            left--;
        }

        while(right < nums.Length){
            resNums[pos++] = nums[right] * nums[right];
            right++;
        }

        return resNums;
        
    }
}
