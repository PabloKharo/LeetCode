using System;
using System.Linq;
using System.Collections.Generic;

public partial class JulySolution {
    public IList<int> GrayCode(int n) {
        List<int> res = new List<int>();
        int powedN = 1 << n;
        for(int i = 0; i < powedN; i++)
            res.Add(i ^ (i >> 1));

        return res;
    }
}