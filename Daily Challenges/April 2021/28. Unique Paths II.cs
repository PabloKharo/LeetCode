using System;

public partial class AprilSolution {
    public int UniquePathsWithObstacles(int[][] obstacleGrid) {
        int n = obstacleGrid.Length;
        int m = obstacleGrid[0].Length;
        if(obstacleGrid[0][0] == 1 || obstacleGrid[n-1][m-1] == 1)
            return 0;

        int ok = 1;
        for(int i = 0; i < n; i++){
            if(obstacleGrid[i][0] == 1)
                ok = 0;
            obstacleGrid[i][0] = ok;
        }

        ok = 1;
        for(int j = 1; j < m; j++){
            if(obstacleGrid[0][j] == 1)
                ok = 0;
            obstacleGrid[0][j] = ok;
        }

        for(int i = 1; i < n; i++){
            for(int j = 1; j < m; j++){
                if(obstacleGrid[i][j] == 1){
                    obstacleGrid[i][j] = 0;
                    continue;
                }

                int upper = obstacleGrid[i-1][j];
                int left = obstacleGrid[i][j-1];
                obstacleGrid[i][j] = left + upper;
            }
        }

        return obstacleGrid[n-1][m-1];
    }

}