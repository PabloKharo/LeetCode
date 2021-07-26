#include <bits/stdc++.h>

using namespace std;

// Definition for a Node.
class Node {
public:
    int val;
    Node* left;
    Node* right;
    Node* next;

    Node() : val(0), left(NULL), right(NULL), next(NULL) {}

    Node(int _val) : val(_val), left(NULL), right(NULL), next(NULL) {}

    Node(int _val, Node* _left, Node* _right, Node* _next)
        : val(_val), left(_left), right(_right), next(_next) {}
};

class MedInterSolution {
public:
    Node* connect(Node* root) {
        if(root == nullptr)
            return root;

        queue<Node*> curQ;
        queue<Node*> nextQ;
        curQ.push(root);

        Node* fromNode = root;
        Node* toNode;
        while(curQ.size() != 0){
            curQ.pop();
            if(fromNode->left != nullptr){
                nextQ.push(fromNode->left);
                nextQ.push(fromNode->right);
            }

            if(curQ.size() == 0){
                nextQ.swap(curQ);
                fromNode = curQ.front();
                continue;
            }

            toNode = curQ.front();
            fromNode->next = toNode; 
            fromNode = toNode;     
        }

        return root;
    }
};