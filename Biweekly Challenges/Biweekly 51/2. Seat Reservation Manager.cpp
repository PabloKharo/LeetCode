#include "bits/stdc++.h"

using namespace std;

class Biweek51Solution {
public:
    class SeatManager {
    public:
    
        vector<bool> res;
        int small;
        int prevsmall;
        SeatManager(int n) {
            res.resize(n+1, false);
            small = 0;
            prevsmall = 0;
        }
        
        int reserve() {
            int rese = small;
            res[small++] = true;
            if(res[small] == true){
                if(prevsmall > small)
                    small = prevsmall;
                else{
                    while(res[small] == true){
                        small++;
                    }
                }
            }
            return rese + 1;
        }
        
        void unreserve(int seatNumber) {
            res[seatNumber - 1] = false;
            if(small > seatNumber - 1){
                prevsmall = small;
                small = seatNumber - 1;
            }else{
                if(prevsmall > seatNumber - 1){
                    prevsmall = seatNumber - 1;
                }
            }
        }
    };
    
    /**
     * Your SeatManager object will be instantiated and called as such:
     * SeatManager* obj = new SeatManager(n);
     * int param_1 = obj->reserve();
     * obj->unreserve(seatNumber);
     */
};