using System;

public partial class Arrays101Solution {
    public void MoveZeroes(int[] nums) {
        int zeros = 0;

        for(int i = 0; i < nums.Length; i++){
            if(nums[i] == 0){
                zeros++;
            }else{
                nums[i-zeros] = nums[i];
            }
        }
        for(int i = nums.Length - zeros; i < nums.Length; i++){
            nums[i] = 0;
        }
    }
}