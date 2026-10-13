using System;

public class Solution {
    public string solution(int[] food) {
        string answer = "";
        string str = "";
        
        for(int i=1; i<food.Length; i++){
            if(food[i] / 2 >= 1){
                for(int j=0; j<food[i] / 2; j++){
                    answer+= i;
                }
            }
        }
        
        for(int i = answer.Length-1; i>=0; i--){
            str+=answer[i];
        }
        
        answer+=0;
        
       for(int i=0; i<str.Length; i++){
           answer += str[i];
       }
        
        
        return answer;
    }
}