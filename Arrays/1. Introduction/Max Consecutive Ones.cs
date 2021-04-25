using System;
public partial class CompletedSolution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        int maxCons = 0;
        int curCons = 0;
        foreach(int num in nums){
            if(num == 0){
                maxCons = Math.Max(maxCons, curCons);
                curCons = 0;
            }else{
                curCons++;
            }
        }
        maxCons = Math.Max(maxCons, curCons);
        return maxCons;
    }
}
