using System;
using System.Collections.Generic;
using System.Linq;


public partial class AprilSolution {
    public IList<int> PowerfulIntegers(int x, int y, int bound) {
        HashSet<int> set = new HashSet<int>();
        
        for(int i = 1; i <= bound; i *= x){
            for(int j = 1; i + j <= bound; j *= y){
                set.Add(i + j);

                if(y == 1)
                    break;
            }

            if(x == 1)
                break;
        }
        List<int> res = new List<int>(set);
        
        return res;
    }

}