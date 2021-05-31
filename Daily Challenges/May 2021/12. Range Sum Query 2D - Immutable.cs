using System;
using System.Linq;
using System.Collections.Generic;

public partial class MaySolution {

    public class NumMatrix {
    List<List<int>> sums;
    public NumMatrix(int[][] matrix) {
        sums = new List<List<int>>();
        for(int i = 0; i < matrix.Length; i++){
            int sum = 0;
            sums.Add(new List<int>());
            sums[i].Add(0);
            for(int j = 0; j < matrix[i].Length; j++){
                sum += matrix[i][j];
                sums[i].Add(sum);
            }
        }
        
    }
    
    public int SumRegion(int row1, int col1, int row2, int col2) {
        int res = 0;
        for(int i = row1; i <= row2; i++){
            res += sums[i][col2+1] - sums[i][col1];
        }
        return res;
    }
    }

}