using System;
using System.Linq;
using System.Collections.Generic;

public partial class MaySolution {
    public int MinPartitions(string n) {
        int res = '0';
        for(int i = 0; i < n.Length; i++){
            res = Math.Max(res, n[i]);
        }
        return (res - '0');
    }

}