using System;
using System.Linq;
public partial class CompletedSolution {
    public void DuplicateZeros(int[] arr) {
        int shift = 0;
        int[] newArr = arr.ToArray();
        for(int i = 0; i < arr.Length; i++){
            arr[i] = 0;
        }
        for(int i = 0; i + shift < arr.Length; i++){
            if(newArr[i] == 0){
                shift++;
            }else{
                arr[i+shift] = newArr[i];
            }
        }
    }
}