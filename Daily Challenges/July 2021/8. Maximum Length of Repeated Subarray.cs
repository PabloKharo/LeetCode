using System;
using System.Linq;
using System.Collections.Generic;

public partial class JulySolution
{
    public int FindLength(int[] nums1, int[] nums2) {
        int[] minArr = (nums1.Length < nums2.Length) ? nums1 : nums2;
        int[] maxArr = (nums1.Length < nums2.Length) ? nums2 : nums1;

        int[] curRow = new int[minArr.Length + 1];
        int[] prevRow = new int[minArr.Length + 1];

        int res = 0;

        for(int i = 0; i < maxArr.Length; ++i)
        {
            for(int j = 0; j < minArr.Length; ++j)
            {
                if (minArr[j] == maxArr[i])
                {
                    curRow[j + 1] = prevRow[j] + 1;
                    res = Math.Max(res, curRow[j + 1]);
                }
                else
                    curRow[j + 1] = 0;
            }

            Array.Copy(curRow, prevRow, curRow.Length);
        }


        return res;

    }
}