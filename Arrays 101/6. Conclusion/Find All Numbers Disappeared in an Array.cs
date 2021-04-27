using System;
using System.Linq;
using System.Collections;

public partial class Arrays101Solution {
    // public IList<int> FindDisappearedNumbers(int[] nums) {
    public int[] FindDisappearedNumbers(int[] nums) {

        int unique = nums.Length;
        for(int i = 0; i < nums.Length; i++){
            int num = Math.Abs(nums[i]);
            if(nums[num - 1] > 0){
                nums[num - 1] *= -1;
                unique--;
            }
        }

        int[] list = new int[unique];
        int pos = 0;
        for(int i = 0; i < nums.Length; i++){
            if(nums[i] > 0)
                list[pos++] = i + 1;
        }
        return list;
    }

}