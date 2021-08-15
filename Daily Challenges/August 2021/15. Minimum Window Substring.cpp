#include <bits/stdc++.h>

using namespace std;

class AugustSolution {
public:
    string minWindow(string s, string t) {
        unordered_map<char, int> dict;
        for (int i = 0; i < t.size(); i++) {
            dict[t[i]] += 1;
        }

        int minLeftPos = -1;
        int minLen = 1000000;

        int leftPos = 0;
        int count = 0;
        char curChar = 'a';
        for (int i = 0; i < s.size(); i++)
        {
            curChar = s[i];
            if (!dict.count(curChar)) {
                continue;
            }

            dict[curChar]--;
            if (dict[curChar] != 0) {
                continue;
            }

            count++;
            if (count == dict.size()) {
                while (leftPos < i) {
                    leftPos++;
                    if (!dict.count(s[leftPos - 1])) {
                        continue;
                    }

                    dict[s[leftPos - 1]]++;
                    if (dict[s[leftPos - 1]] > 0) {
                        count--;
                        break;
                    }
                }

                if (count != dict.size() && i - leftPos + 2 < minLen) {
                    minLen = max(i - leftPos + 2, (int)t.size());
                    minLeftPos = leftPos - 1;
                }
                else if(count == dict.size() && i - leftPos + 1 < minLen){
                    minLen = max(i - leftPos + 1, (int)t.size());
                    minLeftPos = leftPos;
                }
            }
        }

        if (minLeftPos == -1)
            return "";

        string res = "";

        for (int i = minLeftPos; i < s.size() && i < minLeftPos + minLen ; i++) {
            res += s[i];
        }

        return res;
    }
};