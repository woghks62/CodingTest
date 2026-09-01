using System;

public class Solution {
    public int[] solution(int[] emergency) {
        
        int[] answer = new int[emergency.Length];
        int num = 0;
        int count = 1;
        
        for(int i=0; i<emergency.Length; i++){
            count = 1;
            for(int j= 0; j<emergency.Length; j++){
                if(emergency[i] < emergency[j]){
                    count++;
                }
            }
            answer[i] = count;
        }
        
        return answer;
    }
}