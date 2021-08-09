#include <bits/stdc++.h>

using namespace std;

class AugustSolution {
public:
    void dfs(vector<vector<int>>& grid, int i, int j, int& islSize, int& islNum){
        islSize++;
        grid[i][j] = islNum;
        if(j > 0 && grid[i][j-1] == 1){
            dfs(grid, i, j-1, islSize, islNum);
        }
        if(i > 0 && grid[i-1][j] == 1){
            dfs(grid, i-1, j, islSize, islNum);
        }
        if(j < grid[i].size() - 1 && grid[i][j+1] == 1){
            dfs(grid, i, j+1, islSize, islNum);
        }
        if(i < grid.size() - 1 && grid[i+1][j] == 1){
            dfs(grid, i+1, j, islSize, islNum);
        }
    }


    int largestIsland(vector<vector<int>>& grid) {
        vector<int> sizes;
        sizes.push_back(0);
        sizes.push_back(0);
        int islSize = 0;
        int islNum = 2;

        for(int i = 0; i < grid.size(); i++){
            for(int j = 0; j < grid[i].size(); j++){
                if(grid[i][j] == 1){
                    islSize = 0;
                    dfs(grid, i, j, islSize, islNum);
                    islNum++;
                    sizes.push_back(islSize);
                }
            }
        }

        int res = -1;
        int thisMax = 0;
        int left, up, right, down;
        for(int i = 0; i < grid.size(); i++){
            for(int j = 0; j < grid[i].size(); j++){
                if(grid[i][j] == 0){
                    left = up = right = down = -1;
                    thisMax = 1;
                    if(j > 0){
                        left = grid[i][j-1];
                        thisMax += sizes[left];
                    }
                    if(i > 0){
                        up = grid[i-1][j];
                        if(up != left)
                            thisMax += sizes[up];
                    }
                    if(j < grid[i].size() - 1){
                        right = grid[i][j+1];
                        if(right != left && right != up)
                            thisMax += sizes[right];
                    }
                    if(i < grid.size() - 1){
                        down = grid[i+1][j];
                        if(down != left && down != up && down != right)
                            thisMax += sizes[down];
                    }

                    res = max(res, thisMax);
                }
            }
        }

        if(res == -1)
            res = sizes[2];

        return res;
    }
};