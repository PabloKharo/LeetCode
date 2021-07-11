#include <bits/stdc++.h>

using namespace std;

class HardInterSolution {
private:
    struct ListNode {
        int val;
        ListNode *next;
        ListNode() : val(0), next(nullptr) {}
        ListNode(int x) : val(x), next(nullptr) {}
        ListNode(int x, ListNode *next) : val(x), next(next) {}
    };

public:
    ListNode* mergeKLists(vector<ListNode*>& lists) {
        auto comp = [](ListNode* lhs, ListNode* rhs) {
            return lhs->val > rhs->val;
        };

        priority_queue<ListNode*, vector<ListNode*>, decltype(comp)> q(comp);
        for (int i = 0; i < lists.size(); i++) {
            if (lists[i] != nullptr) {
                q.push(lists[i]);
            }
        }
        if (q.empty()) {
            return nullptr;
        }

        ListNode* rHead = nullptr;
        ListNode* minNode = q.top(); q.pop();
        if (minNode->next != nullptr) {
            q.push(minNode->next);
        }

        rHead = new ListNode(minNode->val);
        ListNode* pNode = rHead;

        while (!q.empty()) {
            minNode = q.top(); q.pop();
            if (minNode->next != nullptr) {
                q.push(minNode->next);
            }

            pNode->next = new ListNode(minNode->val);
            pNode = pNode->next;
        }

        return rHead;
    }
};