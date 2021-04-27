using System;

public partial class Arrays101Solution {
    public int RemoveElement(int[] nums, int val) {
        int pos = 0;
        for(int i = 0; i < nums.Length; i++){
            if(nums[i] != val){
                nums[pos++] = nums[i];
            }
        }

        return pos;
    }
}