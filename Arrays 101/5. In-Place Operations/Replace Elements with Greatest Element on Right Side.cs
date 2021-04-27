using System;

public partial class Arrays101Solution {
    public int[] ReplaceElements(int[] arr) {
        int maxVal = arr[arr.Length - 1];
        arr[arr.Length - 1] = -1;

        for(int i = arr.Length - 2; i >= 0; i--){
            int tmp = arr[i];
            arr[i] = maxVal;
            maxVal = Math.Max(tmp, maxVal);
        }
        return arr;
    }
}