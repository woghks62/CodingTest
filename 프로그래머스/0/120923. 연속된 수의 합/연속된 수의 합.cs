using System;

public class Solution {
    public int[] solution(int num, int total) {
        int[] answer = new int[num];
        
        int a;
        int b = 0;
        
        for(int i=0; i<num; i++){
            b+=i;
        }
        
        a = (total - b) / num;
        
        for(int i=0; i<num; i++){
            answer[i] = a;
            a++;
        }

        
        
        return answer;
    }
}