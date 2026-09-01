using System;

public class Solution {
    public int solution(int[] sides) {
        int answer = 0;
        int temp = 0;
        
        for(int i=0; i<sides.Length-1; i++){
            for(int j=0; j<sides.Length-1-i; j++){
                if(sides[j] > sides[j+1]){
                    temp = sides[j];
                    sides[j] = sides[j+1];
                    sides[j+1] = temp;
                }
            }
        }
        
        if(sides[2] < sides[0] + sides[1]){
            answer = 1;
        }
        else{
            answer = 2;
        }
        
        return answer;
    }
}