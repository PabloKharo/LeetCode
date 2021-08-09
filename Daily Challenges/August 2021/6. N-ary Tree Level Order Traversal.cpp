#include <bits/stdc++.h>

using namespace std;

class Node {
public:
    int val;
    vector<Node*> children;

    Node() {}

    Node(int _val) {
        val = _val;
    }

    Node(int _val, vector<Node*> _children) {
        val = _val;
        children = _children;
    }
};

class AugustSolution {
public:
    vector<vector<int>> levelOrder(Node* root) {
        vector<vector<int>> res;
        if(root == nullptr)
            return res;
        
        queue<Node*> q;
        int qSize = 0;
        q.push(root);

        while(!q.empty())
        {
            qSize = q.size();
            res.push_back(vector<int>(qSize));
            for(int i = 0; i < qSize; i++){
                res.back()[i] = q.front()->val;
                for(int node = 0; node < q.front()->children.size(); node++){
                    q.push(q.front()->children[node]);
                }
                q.pop();
            }
        }

        return res;
    }
};