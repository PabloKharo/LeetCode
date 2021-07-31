#include <bits/stdc++.h>

using namespace std;

class MedInterSolution {
public:
    int coinChange(vector<int>& coins, int amount) {
        vector<int> minCoins(amount + 1, INT_MAX);
        minCoins[0] = 0;
        for (int i = 0; i < coins.size(); i++) {
            if (coins[i] <= amount)
                minCoins[coins[i]] = 1;
        }

        for (int i = 1; i <= amount; i++) {
            for (int j = 0; j < coins.size(); j++) {
                if (i - coins[j] >= 0 && minCoins[i - coins[j]] != INT_MAX)
                    minCoins[i] = min(minCoins[i], minCoins[i - coins[j]] + 1);
            }
        }

        if (minCoins[amount] == INT_MAX)
            return -1;

        return minCoins[amount];
    }
};