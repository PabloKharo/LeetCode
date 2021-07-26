using System;
using System.Linq;
using System.Collections.Generic;

public partial class JulySolution
{
    int[] curArr, origArr;
    public void Solution(int[] nums) {
        curArr = new int[nums.Length];
        origArr = new int[nums.Length];

        Array.Copy(nums, curArr, nums.Length);
        Array.Copy(nums, origArr, nums.Length);
    }
    
    /** Resets the array to its original configuration and return it. */
    public int[] Reset() {
        Array.Copy(origArr, curArr, origArr.Length);
        return curArr;
    }
    
    /** Returns a random shuffling of the array. */
    public int[] Shuffle() {
        List<int> inds = new List<int>();
        inds = curArr.ToList();

        Random rnd = new Random();
        int ind = 0;
        for(int i = 0; i < curArr.Length; i++)
        {
            ind = rnd.Next(inds.Count);
            curArr[i] = inds[ind];
            inds.RemoveAt(ind);
        }

        return curArr;
    }
}