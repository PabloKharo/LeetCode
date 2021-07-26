#include <bits/stdc++.h>
#include <unordered_set>

using namespace std;

class HardInterSolution {
public:
    int ladderLength(string beginWord, string endWord, vector<string>& wordList) {
        unordered_set<string> words(wordList.begin(), wordList.end());
        if(words.count(endWord) == 0)
            return 0;

        int count = 1;
        int len = 0;
        char c = 'a';
        string word = "";

        queue<string> curQ;
        curQ.push(beginWord);
        while(!curQ.empty()){
            len = curQ.size();
            for(int i = 0; i < len; i++){
                word = curQ.front(); curQ.pop();
                if(word == endWord)
                    return count;
                for(int j = 0; j < word.size(); j++){
                    c = word[j];
                    for(int k = 0; k < 26; k++){
                        word[j] = 'a' + k;
                        if(words.find(word) != words.end()){
                            curQ.push(word);
                            words.erase(word);
                        }
                    }
                    word[j] = c;
                }
                
            }
            count++;
        }

        return 0;
    }
};