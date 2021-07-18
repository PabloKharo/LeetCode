using System;
using System.Linq;
using System.Collections.Generic;

public partial class EasyInterSolution
{
    public int[] Intersect(int[] nums1, int[] nums2) {
        int[] minArr = (nums1.Length < nums2.Length) ? nums1 : nums2;
        int[] maxArr = (nums1.Length < nums2.Length) ? nums2 : nums1;

        Dictionary<int, int> dict = new Dictionary<int, int>();
        List<int> myList = new List<int>();
        for(int i = 0; i < minArr.Length; i++)
        {
            if(dict.ContainsKey(minArr[i]))
                dict[minArr[i]]++;
            else
                dict.Add(minArr[i], 1);
        }

        for(int i = 0; i < maxArr.Length; i++)
        {
            if(dict.ContainsKey(maxArr[i]))
            {
                myList.Add(maxArr[i]);
                dict[maxArr[i]]--;
                if(dict[maxArr[i]] == 0)
                    dict.Remove(maxArr[i]);
            }
        }

        return myList.ToArray();
    }
}