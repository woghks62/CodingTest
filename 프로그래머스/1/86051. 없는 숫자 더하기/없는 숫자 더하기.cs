using System;

public class Solution {
    public int solution(int[] numbers) {
        int answer = -1;
        int sum = 0;
        
        for(int i=0; i<numbers.Length; i++){
            for(int j=0; j<=9; j++){
                if(numbers[i] == j){
                    sum+=j;
                }
            }
        }
        answer = 45 - sum;
        
        return answer;
    }
}