using System;

public class Solution {
    public int solution(int[] numbers, int k) {
        int answer = 1;
        
        for(int i=0; i<k-1; i++){
            if(answer > numbers.Length){
                answer = 1;
            }
            answer++;
            if(answer > numbers.Length){
                answer = 1;
            }
            answer++;
            if(answer > numbers.Length){
                answer = 1;
            }
        }
        
        return answer;
    }
}