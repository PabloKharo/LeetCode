using System;
using System.Linq;
using System.Collections.Generic;

public partial class HardInterSolution
{
    public void Dfs(int[][] m, int city, ref bool[] wasVisited)
    {
        wasVisited[city] = true;
        for (int i = 0; i < m.Length; ++i)
        {
            if(m[city][i] == 1 && !wasVisited[i])
                Dfs(m, i, ref wasVisited);
        }
    }

    public int FindCircleNum(int[][] isConnected) {
        int n = isConnected.Length;
        int res = 0; 
        bool[] wasVisited = new bool[n];

        for (int i = 0; i < n; ++i)
        {
            if (!wasVisited[i])
            {
                Dfs(isConnected, i, ref wasVisited);
                res++;
            }
        }

        return res;
    }
}