#include <bits/stdc++.h>

using namespace std;

class MedInterSolution {
public:
    void remIsland(vector<vector<char>>& grid, int i, int j){
        grid[i][j] = 0;

        if(i > 0 && grid[i-1][j] == '1') // up
            remIsland(grid, i-1, j);
        if(i < grid.size()-1 && grid[i+1][j] == '1') // down
            remIsland(grid, i+1, j);
        if(j > 0 && grid[i][j-1] == '1') // left
            remIsland(grid, i, j-1);
        if(j < grid[i].size()-1 && grid[i][j+1] == '1') // right
            remIsland(grid, i, j+1);
    }

    int numIslands(vector<vector<char>>& grid) {
        int res = 0;
        for(int i = 0; i < grid.size(); i++){
            for(int j = 0; j < grid[i].size(); j++){
                if(grid[i][j] == '1'){
                    res++;
                    remIsland(grid, i, j);
                }
            }
        }

        return res;
    }
};