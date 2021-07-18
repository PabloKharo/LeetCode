using System;
using System.Linq;
using System.Collections.Generic;

public partial class EasyInterSolution
{
    public void Rotate(int[] nums, int k) {
        if (k % nums.Length == 0)
            return;

        int left = 0;
        int count = 0;

        while(count < nums.Length)
        {
            int curPos = (left + k) % nums.Length;
            int prev = nums[left];
            int tmp = 0;
            while(left != curPos)
            {
                tmp = nums[curPos];
                nums[curPos] = prev;
                prev = tmp;
                count++;
                curPos = (curPos + k) % nums.Length;
            }
            nums[left] = tmp;
            count++;
            left++;
        }

    }
}