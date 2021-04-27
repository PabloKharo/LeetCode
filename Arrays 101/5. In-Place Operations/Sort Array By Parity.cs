using System;

public partial class Arrays101Solution {
    public int[] SortArrayByParity(int[] A) {
        int i = 0;
        int j = A.Length - 1;

        while(i < j){
            if(A[i] % 2 == 0){
                if(A[j] % 2 == 1)
                    j--;
                i++;
            }else{
                if(A[j] % 2 == 0){
                    int tmp = A[j];
                    A[j] = A[i];
                    A[i] = tmp;
                    i++; 
                }
                j--;
            }
        }

        return A;
    }
}