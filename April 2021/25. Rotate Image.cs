using System;

public partial class CompletedSolution {
    public void Rotate(int[][] matrix) {    
        for(int i = 0; i < matrix.Length / 2; i++){
            int side = matrix[i].Length - 1 - i;
            for(int j = 0; j < side - i; j++){
                int tmp = matrix[i][i+j];
                matrix[i][i+j] = matrix[side - j][i];
                matrix[side - j][i] = matrix[side][side - j];
                matrix[side][side - j] = matrix[i+j][side];
                matrix[i+j][side] = tmp;
            }
        }

    }
}