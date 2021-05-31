using System;
using System.Collections.Generic;

public partial class MaySolution {
    public int CountPrimes(int n) {
        int res = 0;
        if(n < 2)
            return res;
        List<bool> list = new List<bool>(new bool[n]);

        for(int i = 2; i * i < n; i++){
            if(list[i] == true){
                continue;
            }
            for(int j = i*i; j < n; j += i){
                list[j] = true;
            }
        }

        for(int i = 2; i < n; i++){
            if(list[i] == false)
                res++;
        }

        return res;
    }
}