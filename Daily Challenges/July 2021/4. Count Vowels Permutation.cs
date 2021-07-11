using System;
using System.Linq;
using System.Collections.Generic;

public partial class JulySolution {
    public int CountVowelPermutation(int n) {
        const int mod = 1000000007;
        long[] cRow = new long[5];//a, e, i, o, u
        long[] pRow = new long[5] { 1, 1, 1, 1, 1 }; 
        for (int i = 1; i < n; i++)
        {
            cRow[0] = (pRow[1] + pRow[2] + pRow[4]) % mod;   // a = e+i+u
            cRow[1] = (pRow[0] + pRow[2]) % mod;             // e = a+i
            cRow[2] = (pRow[1] + pRow[3]) % mod;             // i = e+o
            cRow[3] = pRow[2];                               // o = i
            cRow[4] = (pRow[2] + pRow[3]) % mod;             // u = i+o

            Array.Copy(cRow, pRow, 5);
        }

        long res = 0;
        for (int i = 0; i < 5; i++)
            res = (res + pRow[i]) % mod;

        return (int)res;
    }
}