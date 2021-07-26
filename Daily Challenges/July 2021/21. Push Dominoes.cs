using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

public partial class JulySolution
{
    public string PushDominoes(string dominoes) {
        StringBuilder res = new StringBuilder(dominoes, dominoes.Length);
        int leftIndex = -1;
        int diff, med;
        bool rightSide = false;

        for(int i = 0; i < dominoes.Length; i++)
        {
            if(dominoes[i] == 'L')
            {
                if(rightSide)
                {
                    diff = i - leftIndex;
                    med = (leftIndex + i) / 2;
                    if(diff % 2 == 0)
                    {
                        for (int j = leftIndex + 1; j < med; j++)
                            res[j] = 'R';
                        for (int j = med + 1; j < i; j++)
                            res[j] = 'L';
                    }
                    else
                    {
                        for (int j = leftIndex + 1; j <= med; j++)
                            res[j] = 'R';
                        for (int j = med + 1; j < i; j++)
                            res[j] = 'L';
                    }
                    
                }
                else
                {
                    for(int j = leftIndex+1; j < i; j++)
                        res[j] = 'L';
                    
                }
                rightSide = false;
                leftIndex = i;
            }
            else if(dominoes[i] == 'R')
            {
                if (rightSide)
                {
                    for (int j = leftIndex + 1; j < i; j++)
                        res[j] = 'R';
                }
                rightSide = true;
                leftIndex = i;
            }
            
        }

        if(rightSide == true)
        {
            for (int j = leftIndex + 1; j < dominoes.Length; j++)
                res[j] = 'R';
        }


        return res.ToString();
    }
}