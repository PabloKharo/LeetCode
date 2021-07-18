using System;
using System.Linq;
using System.Collections.Generic;

public partial class EasyInterSolution
{
    public int[] PlusOne(int[] digits) {
        bool createFirst = true;
        for(int i = digits.Length - 1; i >= 0; i--)
        {
            digits[i] += 1;
            if(digits[i] < 10)
            {
                createFirst = false;
                break;  
            }
            digits[i] = 0;       
        }
        
        if(createFirst)
        {
            int[] res = new int[digits.Length+1];
            res[0] = 1;
            Array.Copy(digits, 0, res, 1, digits.Length);
            return res;
        }

        return digits;

    }
}