using System;

public partial class Arrays101Solution {
    public bool ValidMountainArray(int[] arr) {
        int i = 1;
        while(i < arr.Length && arr[i-1] < arr[i]){
            i++;
        }

        if(i == arr.Length || i == 1)
            return false;
        
        while(i < arr.Length && arr[i-1] > arr[i]){
            i++;
        }

        if(i != arr.Length)
            return false;

        return true;
    }
}