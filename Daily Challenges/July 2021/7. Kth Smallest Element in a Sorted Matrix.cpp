#include <bits/stdc++.h>

using namespace std;

class JulySolution {
public:
    struct MyData {
        int i;
        int j;
        int val;
        MyData(int _i, int _j, int _val) : i(_i), j(_j), val(_val) {}
    };

    int kthSmallest(vector<vector<int>>& matrix, int k) {
        auto comp = [](MyData lhs, MyData rhs) {
            return lhs.val > rhs.val;
        };

        int n = matrix.size();
        priority_queue<MyData, vector<MyData>, decltype(comp)> q(comp);
        q.push(MyData(0, 0, matrix[0][0]));
        for (int i = 0; i < k - 1; i++) {
            MyData dt = q.top(); q.pop();
            if (dt.j == 0 && dt.i != n - 1) {
                q.push(MyData(dt.i + 1, dt.j, matrix[dt.i + 1][dt.j]));
            }
            if (dt.j != n - 1) {
                q.push(MyData(dt.i, dt.j + 1, matrix[dt.i][dt.j + 1]));
            }
        }

        return q.top().val;
    }

    // int kthSmallest(vector<vector<int>>& matrix, int k) {
    //     int n = matrix.size();
    //     vector<int> vals;
    //     for(int i = 0; i < n; i++){
    //         for(int j = 0; j < n; j++){
    //             vals.push_back(matrix[i][j]);
    //         }
    //     }
    //     sort(vals.begin(), vals.end());
    //     return vals[k-1];
    // }
};