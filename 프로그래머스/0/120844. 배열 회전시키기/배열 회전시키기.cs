using System;

public class Solution {
    public int[] solution(int[] numbers, string direction) {
        int[] answer = new int[numbers.Length];
        
        if(direction == "right"){
            for(int i=0; i<numbers.Length-1; i++){
                    answer[i+1]=numbers[i];
            }
            answer[0] = numbers[numbers.Length-1];
        }
        
        else if(direction == "left"){
            for(int i=numbers.Length-1; i>0; i--){
                    answer[i-1]=numbers[i];
            }
            answer[numbers.Length-1] = numbers[0];
        }
        
        return answer;
    }
}