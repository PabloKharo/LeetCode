using System;
using System.Linq;
using System.Collections.Generic;

public partial class JulySolution
{
    public int[][] MatrixReshape(int[][] mat, int r, int c) 
    {
        int n = mat.Length;
        int m = mat[0].Length;
        if(n*m != r*c)
            return mat;
        
        int[][] res = new int[r][];
        int len = 0;
        for(int i = 0; i < r; i++)
        {
            res[i] = new int[c];
            for(int j = 0; j < c; j++)
            {
                res[i][j] = mat[len / m][len % m];
                len++;
            }
        }

        return res;
    }
}