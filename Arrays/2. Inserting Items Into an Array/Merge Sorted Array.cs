using System;
using System.Linq;

public partial class CompletedSolution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        int f = m - 1;
        int s = n - 1;
        int pos = m + n - 1;

        while(s >= 0){
            if(f >= 0 && nums1[f] > nums2[s]){
                nums1[pos--] = nums1[f--];
            }else{
                nums1[pos--] = nums2[s--];
            }
        }

    }
}
