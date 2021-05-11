using System;
using System.Collections.Generic;

public partial class MaySolution {
    public int MaxScore(int[] cardPoints, int k) {
        int len = cardPoints.Length;
        int comb = 0;

        for (int i = 0; i < k; i++) {
            comb += cardPoints[i];
        }

        int res = comb;
        for (int i = 1; i < k + 1; i++) {
            comb = comb + cardPoints[len - i] - cardPoints[k - i];
            res = Math.Max(res, comb);
        }

        return res;
    }

}