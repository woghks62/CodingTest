using System;

public class Solution {
    public int solution(int[] sides) {
        int answer = 0;
        int max = 0;
        int min = 0;
        
        if(sides[1] >= sides[0]){
            max = sides[1];
            min = sides[0];
        }
        else if(sides[0] > sides[1]){
            max = sides[0];
            min = sides[1];
        }
        
        for(int i=max-min+1; i<=max; i++){
            answer++;
        }
        
        for(int i = max+1; i<=min+max-1; i++){
            answer++;
        }
            
        return answer;
    }
}