using System;

public class Solution {
    public int solution(int slice, int n) {
        int answer = 0;
        int pizza = 0;

        if(slice >= n){
            answer = 1;
        }
        else{
            for(int i=2; i<n; i++){
                if((slice * i) >= n){
                    answer = i;
                    break;
                    // if((slice*i) % n == 0){
                    //     answer = i;
                    //     break;
                    // }
                    // else{
                    //     answer = i+1;
                    //     break;
                    // }
                }
                // if(n % (slice*i) == 0){
                //     answer = i;
                //     break;
                // }
                // else{
                //     if(slice*i > n){
                //         answer = i;
                //         break;
                //     }
                // }
            }
        }
        
        return answer;
    }
}