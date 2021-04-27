using System;
using System.Collections;

public partial class Arrays101Solution {
    public bool CheckIfExist(int[] arr) {
        Hashtable table = new Hashtable();

        foreach(int num in arr){
            if(num % 2 == 0 && table.ContainsKey(num / 2)){
                return true;
            }
            if(table.ContainsKey(num * 2)){
                return true;
            }

            table[num] = true;
        }

        return false;
    }
}