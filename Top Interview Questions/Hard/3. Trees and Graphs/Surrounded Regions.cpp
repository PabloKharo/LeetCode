#include <bits/stdc++.h>

using namespace std;

class HardInterSolution {
public:
    void setIslandChar(vector<vector<char>>& board, int i, int j, char& to, char& from){
        board[i][j] = to;

        if(i > 0 && board[i-1][j] == from) // up
            setIslandChar(board, i-1, j, to, from);
        if(i < board.size()-1 && board[i+1][j] == from) // down
            setIslandChar(board, i+1, j, to, from);
        if(j > 0 && board[i][j-1] == from) // left
            setIslandChar(board, i, j-1, to, from);
        if(j < board[i].size()-1 && board[i][j+1] == from) // right
            setIslandChar(board, i, j+1, to, from);
    }

    void solve(vector<vector<char>>& board) {
        char from = 'O';
        char to = 'I';
        for(int j = 0; j < board[0].size(); j++){
            if(board[0][j] == from)
                setIslandChar(board, 0, j, to, from);
            if(board[board.size()-1][j] == from)
                setIslandChar(board, board.size()-1, j, to, from);
        }

        for(int i = 0; i < board.size(); i++){
            if(board[i][0] == from)
                setIslandChar(board, i, 0, to, from);
            if(board[i][board[i].size()-1] == from)
                setIslandChar(board, i, board[i].size()-1, to, from);
        }

        to = 'X';
        for(int i = 1; i < board.size()-1; i++){
            for(int j = 1; j < board[i].size()-1; j++){
                if(board[i][j] == from)
                    setIslandChar(board, i, j, to, from);
            }
        }

        from = 'I';
        to = 'O';
        for(int j = 0; j < board[0].size(); j++){
            if(board[0][j] == from)
                setIslandChar(board, 0, j, to, from);
            if(board[board.size()-1][j] == from)
                setIslandChar(board, board.size()-1, j, to, from);
        }

        for(int i = 0; i < board.size(); i++){
            if(board[i][0] == from)
                setIslandChar(board, i, 0, to, from);
            if(board[i][board[i].size()-1] == from)
                setIslandChar(board, i, board[i].size()-1, to, from);
        }
    
    }
};