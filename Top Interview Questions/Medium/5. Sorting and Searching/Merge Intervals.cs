using System;
using System.Linq;
using System.Collections.Generic;

public partial class MedInterSolution
{
    public int[][] Merge(int[][] intervals) {
        Array.Sort(intervals, (lhs, rhs) => lhs[0].CompareTo(rhs[0]));
        List<int[]> res = new List<int[]>();
        int[] curInter = intervals[0];
        for(int i = 1; i < intervals.Length; i++)
        {
            if(intervals[i][0] > curInter[1])
            {
                res.Add(curInter);
                curInter = intervals[i];
            }
            else
                curInter[1] = Math.Max(intervals[i][1], curInter[1]);
        }
        res.Add(curInter);

        return res.ToArray();
    }
}